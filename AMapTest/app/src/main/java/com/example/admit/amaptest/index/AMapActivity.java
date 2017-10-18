package com.example.admit.amaptest.index;

import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.support.v4.content.ContextCompat;
import android.support.v4.view.ViewPager;
import android.support.v7.widget.RecyclerView;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import com.amap.api.maps.AMap;
import com.amap.api.maps.AMapOptions;
import com.amap.api.maps.MapView;
import com.amap.api.maps.UiSettings;
import com.amap.api.maps.model.CameraPosition;
import com.amap.api.maps.model.LatLng;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.route.RouteSearch;
import com.example.admit.amaptest.Mine.MineActivity;
import com.example.admit.amaptest.MySchedule.BusRouteSearchManager;
import com.example.admit.amaptest.MySchedule.MyScheduleActivity;
import com.example.admit.amaptest.MySchedule.StartToEndViewGroup;
import com.example.admit.amaptest.MyUtil.NetworkUtil;
import com.example.admit.amaptest.MyUtil.RegeocodeAddressUtil;
import com.example.admit.amaptest.MyUtil.ViewGroupAnimator;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.search.SearchActivity;

import java.util.ArrayList;
import java.util.List;


/**
 * AMap.OnMapClickListener,AMap.OnCameraChangeListener
 * 必须在主线程中调用
 */
public class AMapActivity extends SingleAMapActivity implements ViewpagerManageable, View.OnClickListener, AMapManageable, AMap.OnMapClickListener, AMap.OnCameraChangeListener {
    public static final String TAG = "TAG";
    private AMapFragment myfragment;
    private MapView mapView;
    private AMap aMap;
    private MyLocationManager myLocationManager;
    private UiSettings mUiSettings;
    private MyBusPoiManager busPoiManager;
    private StartToEndViewGroup startToEndViewGroup;
    private TextView tvTop;
    private ImageButton imgBtnMine;
    private Button searchNearby;
    private ImageButton imgBtnScchedule;
    private ImageButton imgLocation;
    private TextView tvBottom;
    private ViewPager viewPager;
    private List<View> viewContainer = new ArrayList<>();

    /**
     * 创建Activityde的实例对象，初始化Activity
     */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setPermission();
        startToEndViewGroup = (StartToEndViewGroup) findViewById(R.id.viewgroup_myschedule);
        startToEndViewGroup.setOnClickListener(this);
        tvTop = (TextView) findViewById(R.id.tv_top);
        imgBtnMine = (ImageButton) findViewById(R.id.btn_mine);
        searchNearby = (Button) findViewById(R.id.btn_searchNearby);
        imgBtnScchedule = (ImageButton) findViewById(R.id.btn_schedule);
        imgLocation = (ImageButton) findViewById(R.id.btn_location);
        tvBottom = (TextView) findViewById(R.id.tv_bottom);
        tvTop.setOnClickListener(this);
        imgBtnMine.setOnClickListener(this);
        searchNearby.setOnClickListener(this);
        imgBtnScchedule.setOnClickListener(this);
        imgLocation.setOnClickListener(this);

    }

    @Override
    protected AMapFragment createFragment() {
        Log.i(TAG, "createFragment: create AMapFragment");
        myfragment = new AMapFragment();
        return myfragment;
    }

    @Override
    public void getAMap(MapView mapView, AMap aMap, MyLocationManager myLocationManager) {
        if (aMap == null)
            Log.i(TAG, "getAMap------->null");
        else {
            this.mapView = mapView;
            this.aMap = aMap;
            this.myLocationManager = myLocationManager;
            this.setmUiSettings();
            if (myLocationManager != null) {
                Log.i(TAG, "getAMap-------->myLocationManager 不为空 ");
            }
            Log.i(TAG, "getAMap--------->get Map successed");
        }
    }

    /**
     * MyLocationManager implements ControlerManageable
     */
    public void showMyLocation(ControlerManageable controlerManageable) {
        controlerManageable.setTextview(this.tvBottom);
    }

    /**
     * 获取地图，并操作
     */
    public void operateAMap() {
        if (((AMapFragment) fragment).getTag() == null) {
            ToastTools.show(AMapActivity.this, "程序出了点问题，请重试");
            Log.i(TAG, "onCreate------> (AMapFragment)fragment).getTag()==null");
        } else {
            ((AMapFragment) fragment).returnAMap(this);
            Log.i(TAG, "afterFragmentResume---------------> " + ((AMapFragment) fragment).getTag());
            if (myLocationManager != null) {
                Log.i(TAG, "onClick---------> myLocationManager!=null");
                if (myLocationManager.getMyCity() != null)
                    Log.i(TAG, "afterFragmentResume------------------> my city is " + myLocationManager.getMyCity());
            }
        }
    }

    private void setPermission() {
        /**
         * 关于权限设置
         */
        List<String> permissionList = new ArrayList<>();
        if (ContextCompat.checkSelfPermission(AMapActivity.this, android.Manifest.permission.ACCESS_FINE_LOCATION) !=
                PackageManager.PERMISSION_GRANTED) {
            permissionList.add(android.Manifest.permission.ACCESS_FINE_LOCATION);
            Log.i(TAG, "onCreate: ACCESS_FINE_LOCATION");
        }
        if (ContextCompat.checkSelfPermission(AMapActivity.this, android.Manifest.permission.READ_PHONE_STATE) !=
                PackageManager.PERMISSION_GRANTED) {
            permissionList.add(android.Manifest.permission.READ_PHONE_STATE);
            Log.i(TAG, "onCreate: READ_PHONE_STATE");
        }
        if (ContextCompat.checkSelfPermission(AMapActivity.this, android.Manifest.permission.WRITE_EXTERNAL_STORAGE) !=
                PackageManager.PERMISSION_GRANTED) {
            permissionList.add(android.Manifest.permission.WRITE_EXTERNAL_STORAGE);
        }
    }

    public void setmUiSettings() {
        mUiSettings = this.aMap.getUiSettings();
        if (mUiSettings != null) {
            Log.i(TAG, "setmUiSettings------------> 设置缩放控件中");
            mUiSettings.setCompassEnabled(true);
            mUiSettings.setScaleControlsEnabled(true);
            mUiSettings.setZoomPosition(AMapOptions.ZOOM_POSITION_RIGHT_BUTTOM);
        }
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.btn_searchNearby:
                if (NetworkUtil.isConnected(AMapActivity.this)) {
                    this.myLocationManager.moveCamera(new LatLng(this.aMap.getMyLocation().getLatitude(), this.aMap.getMyLocation().getLongitude()));
                    this.mUiSettings.setZoomPosition(AMapOptions.ZOOM_POSITION_RIGHT_CENTER);
                    viewPager = (ViewPager) findViewById(R.id.viewpager);
                    if (viewPager.getVisibility() == View.GONE || viewPager.getVisibility() == View.INVISIBLE) {
                        Log.i(TAG, "onActivityResult---------------> viewpager");
                        viewPager.setVisibility(View.VISIBLE);
                    }
                    busPoiManager = new MyBusPoiManager(AMapActivity.this, this.aMap, this.myLocationManager.getLatLngOfMyself(), this.myLocationManager.getMyCityCode());
                    busPoiManager.busPoiSearchNearby(this, busPoiManager, this.viewContainer);
                } else ToastTools.show(AMapActivity.this, "请检查网络连接");
                break;
            case R.id.tv_top:
                Intent intent = new Intent(AMapActivity.this, SearchActivity.class);
                intent.putExtra("data_nameOfMycity", this.myLocationManager.getMyCity());
                startActivityForResult(intent, 'A' + 'M' + 'A');
                break;
            case R.id.btn_location:
                if (this.aMap.getMyLocation() != null)
                    this.myLocationManager.moveCamera(new LatLng(this.aMap.getMyLocation().getLatitude(), this.aMap.getMyLocation().getLongitude()));
                else
                    ToastTools.show(AMapActivity.this, "定位异常，请检查网络");
                break;
            case R.id.viewgroup_myschedule:
            case R.id.btn_schedule:
                startToEndViewGroup.getMyCityName(myLocationManager.getMyCity());
                DisplayMetrics dm = new DisplayMetrics();
                getWindowManager().getDefaultDisplay().getMetrics(dm);
                int screenHeigh = dm.heightPixels;
                ViewGroupAnimator.setAnimator(startToEndViewGroup, 'H', startToEndViewGroup.getHeight(), startToEndViewGroup.getLastHeight());
                break;
            case R.id.btn_mine:
                Intent intent1=new Intent(AMapActivity.this,MineActivity.class);
                startActivity(intent1);
                break;
            default:
                break;
        }
    }

    public static void actionstart(Context context, int contextResultCode, double lat, double lon, String CodeOrName) {
        Intent intent = new Intent(context, AMapActivity.class);
        intent.putExtra("SearchResult_lat", lat);
        intent.putExtra("SearchResult_lon", lon);
        intent.putExtra("SearchResult_code", CodeOrName);
        intent.putExtra("SearchResult_locationName", CodeOrName);
        switch (contextResultCode) {
            case 'S' + 'A':
                ((SearchActivity) context).setResult('S' + 'A', intent);
                break;
            case 'M' + 'S' + 'A':
                ((MyScheduleActivity) context).setResult('M' + 'S' + 'A', intent);
                break;
            default:
                break;
        }
        ;

    }

    public static void actionstart(Context context, String cityName) {
        Intent intent = new Intent(context, AMapActivity.class);
        intent.putExtra("SearchResult_locationName", cityName);
        ((MyScheduleActivity) context).setResult(0 + 'M' + 'S' + 'A', intent);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == 'A' + 'M' + 'A' && resultCode == 'S' + 'A') {
            Double lat = data.getDoubleExtra("SearchResult_lat", 0);
            Double lon = data.getDoubleExtra("SearchResult_lon", 0);
            String cityCode = data.getStringExtra("SearchResult_code");
            LatLng searchLatLng = new LatLng(lat, lon);
            aMap.getCameraPosition();
            myLocationManager.moveCamera(searchLatLng);
            this.mUiSettings.setZoomPosition(AMapOptions.ZOOM_POSITION_RIGHT_CENTER);
            viewPager = (ViewPager) findViewById(R.id.viewpager);
            if (viewPager.getVisibility() == View.GONE || viewPager.getVisibility() == View.INVISIBLE) {
                viewPager.setVisibility(View.VISIBLE);
            }
            List<View> views = new ArrayList<>();
            MyBusPoiManager buspoiManager = new MyBusPoiManager(AMapActivity.this, this.aMap, searchLatLng, cityCode);
            buspoiManager.busPoiSearchNearby(this, buspoiManager, views);
        }
        if (requestCode == 'A' + 'M' + 'A' && resultCode == 'M' + 'S' + 'A') {
            Double lat = data.getDoubleExtra("SearchResult_lat", 0);
            Double lon = data.getDoubleExtra("SearchResult_lon", 0);
            String CityNameAndCode = data.getStringExtra("SearchResult_locationName");
            int symbol = CityNameAndCode.indexOf("/");
            startToEndViewGroup.setTextView(startToEndViewGroup.getFlagTextViewId(), CityNameAndCode.substring(0, symbol), lat + "/" + lon);
            if (startToEndViewGroup.getHeight() == 0) {
                DisplayMetrics dm = new DisplayMetrics();
                getWindowManager().getDefaultDisplay().getMetrics(dm);
                int screenHeigh = dm.heightPixels;
                ViewGroupAnimator.setAnimator(startToEndViewGroup, 'H', startToEndViewGroup.getHeight(), screenHeigh * (1 - 0.618f));
            }
            if (startToEndViewGroup.getInputStart().getText().equals("")) {
                //起始位置为默认：当前位置，终点位置为用户输入
                String locStartChar = this.myLocationManager.getMyCity();
                Double latStartPoint = this.myLocationManager.getLatLngOfMyself().latitude;
                Double lonStartPoint = this.myLocationManager.getLatLngOfMyself().longitude;
                Log.i(TAG, "onActivityResult-------------------------------------> " + latStartPoint + " "
                        + lonStartPoint + " " + lat + " " + lon + " " + CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()));
                new BusRouteSearchManager(AMapActivity.this,
                        this.aMap,
                        new LatLonPoint(latStartPoint, lonStartPoint),
                        new LatLonPoint(lat, lon),
                        RouteSearch.BUS_DEFAULT,
                        CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()),
                        1).init();
            } else {
                //起始位置和终点位置都被重置
                switch (startToEndViewGroup.getFlagTextViewId()) {
                    //起始位置刚被输入，终点位置已被输入
                    case StartToEndViewGroup.tv_id_inputStart:
                        if ( !startToEndViewGroup.getInputEnd().getText().equals("") ) {
                            String locEndChar = startToEndViewGroup.getEndLatpoint().getText().toString();
                            int lengthOfEndChar = locEndChar.length();
                            int indexOfspilt=locEndChar.indexOf("/",0);
                            Double latEndPoint = Double.parseDouble(locEndChar.subSequence(0, indexOfspilt).toString());
                            Double lonEndPoint = Double.parseDouble(locEndChar.subSequence(indexOfspilt + 1, lengthOfEndChar).toString());
                            Log.i(TAG, "onActivityResult-------------------------------------> 起始位置刚被输入" + " "
                                    + lat + " " + lon + " " +latEndPoint+""+lonEndPoint+" "+ CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()));
                            myLocationManager.moveCamera(new LatLng(lat,lon));
                            new BusRouteSearchManager(AMapActivity.this,
                                    this.aMap,
                                    new LatLonPoint(lat, lon),
                                    new LatLonPoint(latEndPoint, lonEndPoint),
                                    RouteSearch.BUS_DEFAULT,
                                    CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()),
                                    1).init();
                        }
                        break;
                    //终点位置刚被输入，起始位置已被输入
                    case StartToEndViewGroup.tv_id_inputEnd:
                        String locStartChar = startToEndViewGroup.getStartLatpoint().getText().toString();
                        int lengthOfStartChar = locStartChar.length();
                        int indexOfspilt=locStartChar.indexOf("/",0);
                        Double latStartPoint = Double.parseDouble(locStartChar.subSequence(0, indexOfspilt).toString());
                        Double lonStartPoint = Double.parseDouble(locStartChar.subSequence(indexOfspilt + 1, lengthOfStartChar).toString());
                        Log.i(TAG, "onActivityResult-------------------------------------> 终点位置刚被输入" + locStartChar + " " + latStartPoint + " " + lonStartPoint + " " + lat + " " + lon + " " + CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()));
                        myLocationManager.moveCamera(new LatLng(latStartPoint,lonStartPoint));
                        new BusRouteSearchManager(AMapActivity.this,
                                this.aMap,
                                new LatLonPoint(latStartPoint, lonStartPoint),
                                new LatLonPoint(lat, lon),
                                RouteSearch.BUS_DEFAULT,
                                CityNameAndCode.substring(symbol + 1, CityNameAndCode.length()),
                                1).init();
                        break;
                    default:
                        break;
                }
                ;
            }
        }
    }

    @Override
    public void onMapClick(LatLng latLng) {
        if (viewPager != null) {
            findViewById(R.id.viewpager).setVisibility(View.GONE);
            this.mUiSettings.setZoomPosition(AMapOptions.ZOOM_POSITION_RIGHT_BUTTOM);
        }
        Log.i(TAG, "onMapClick: 逆地理编码中-------> ");
        aMap.clear(true);
        aMap.getCameraPosition();
        new RegeocodeAddressUtil().setADCode(AMapActivity.this, this.aMap, latLng.latitude, latLng.longitude);
        Log.i(TAG, "onMapClick: " + " end" + latLng.latitude + "  " + latLng.longitude);
    }

    @Override
    public void onCameraChange(CameraPosition cameraPosition) {
    }

    @Override
    public void onCameraChangeFinish(CameraPosition cameraPosition) {
    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
        System.exit(0);
    }

    /**
     * 与OnPause()方法同时出现；
     * 此方法执行的频率更高，故其中的代码较少；
     * OnStrat():Activity由不可见变为可见的时候调用
     * 与用户进行交互的时候调用
     */
    @Override
    protected void onResume() {
        super.onResume();
        if (fragmentManager.findFragmentByTag("myFragment") == null) {
            Log.i(TAG, "activity onCreate------> fragment find failed");
        } else {
            Log.i(TAG, "onResume--------> " + fragmentManager.findFragmentByTag("myFragment").getTag());
        }
        Log.i(TAG, "activity onCreate onResume--------------------------------------------->Run end ");
        /*Intent intent=new Intent();
        String searchResult=intent.getStringExtra("SearchResult");
        if(searchResult!=null){
            ToastTools.show(this,searchResult);
        }*/
    }

    /**
     * 系统准备启动或恢复另一个Activity的时候调用；
     * 在此方法中通常用来释放消耗CPU的资源，以及保存一些关键数据；
     * 耗时不能过多；页面仍旧可见。
     */
    @Override
    protected void onPause() {
        super.onPause();
        mapView.onPause();
        Log.i(TAG, "onPause: running");
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
    }

    /**
     * 销毁当前Activity
     */
    @Override
    protected void onDestroy() {
        super.onDestroy();
        this.mapView.onDestroy();
        this.myLocationManager.onDestroy();
        Log.i(TAG, "onDestroy: running");
    }

    @Override
    public void setTitleText(TextView textView, int numOfView) {
    }

    @Override
    public void setRecylerView(RecyclerView recylerView, int numOfView) {
    }

    @Override
    public void setIntroText(TextView textView, int numOfView) {
    }

    @Override
    public void setViewPager(BusLineItemViewpager busLineItemViewpager, int numOfView) {
    }

    @Override
    public void setViewPager(final MyBusPoiManager myBusPoiManager, final MyViewPagerAdapter myViewPagerAdapter) {
        if (this.viewPager != null) {
            this.viewPager.setAdapter(myViewPagerAdapter);
            this.viewPager.setOnPageChangeListener(new ViewPager.OnPageChangeListener() {
                @Override
                public void onPageScrolled(int position, float positionOffset, int positionOffsetPixels) {
                    if (position == (myViewPagerAdapter.getCount() - 1))
                        ToastTools.show(AMapActivity.this, "已是最后一页啦！");
                }

                @Override
                public void onPageSelected(int position) {
                    if (myLocationManager != null) {
                        myLocationManager.moveCamera(new LatLng(myBusPoiManager.myBusStations.get(position).getLatitude(),
                                myBusPoiManager.myBusStations.get(position).getLongitude())
                        );
                    }
                }

                @Override
                public void onPageScrollStateChanged(int state) {

                }
            });
        }
    }
}
