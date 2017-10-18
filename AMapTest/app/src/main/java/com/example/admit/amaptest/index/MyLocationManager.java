package com.example.admit.amaptest.index;

import android.content.Context;
import android.location.Location;
import android.util.Log;
import android.widget.TextView;
import android.widget.Toast;

import com.amap.api.location.AMapLocation;
import com.amap.api.location.AMapLocationClientOption;
import com.amap.api.location.AMapLocationListener;
import com.amap.api.maps.AMap;
import com.amap.api.maps.CameraUpdateFactory;
import com.amap.api.maps.LocationSource;
import com.amap.api.maps.MapView;
import com.amap.api.maps.model.CameraPosition;
import com.amap.api.maps.model.LatLng;
import com.amap.api.maps.model.MyLocationStyle;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;

/**
 * Created by admit on 2017/7/21.
 */

public final class MyLocationManager implements ControlerManageable, AMapLocationListener, LocationSource, LocationSource.OnLocationChangedListener, com.amap.api.maps.AMap.OnMyLocationChangeListener {

    private Context context;
    private MapView mapView;
    private static final String TAG = "TAG";
    private com.amap.api.location.AMapLocationClientOption aMapLocationClientOption;
    public com.amap.api.location.AMapLocationClient aMapLocationClient;
    private com.amap.api.maps.AMap aMap;
    private com.amap.api.maps.model.CameraPosition cameraPosition;
    private com.amap.api.maps.model.CameraPosition.Builder cameraPositionBuilder;
    private com.amap.api.maps.AMapOptions aMapOptions;
    private LocationSource.OnLocationChangedListener onLocationChangedListener;
    private LatLng latLngOfMyself;
    private TextView positionTextView;
    private double myLocationlatLatitude;
    private double myLocationlatLongitude;
    private String myCity;
    private String myAdCode;
    private String myCityCode;
    private TextView textView;

    public MyLocationManager(Context context, MapView mapView, AMap aMap) {
        this.context = context;
        this.mapView = mapView;
        this.aMap = aMap;
    }

    public void setLatLngOfMyself(double myLocationlatLatitude, double myLocationlatLongitude) {
        this.latLngOfMyself = new LatLng(myLocationlatLatitude, myLocationlatLongitude);
    }

    public LatLng getLatLngOfMyself() {
        return this.latLngOfMyself;
    }

    public String getMyCity() {
        return myCity;
    }

    public void setMyCity(String myCity) {
        this.myCity = myCity;
    }

    public String getMyCityCode() {
        return myCityCode;
    }

    public String getMyAdCode() {
        return myAdCode;
    }

    public void setMyAdCode(String myAdCode) {
        this.myAdCode = myAdCode;
    }

    public void setMyCityCode(String myCityCode) {
        this.myCityCode = myCityCode;
    }

    public void setLatLngOfMyself(LatLng latLngOfMyself) {
        this.latLngOfMyself = latLngOfMyself;
    }

    /**
     * 初始化
     */
    public void initMyLocation() {
        /**
         * 定位服务类---AMapLocationClient
         * 定位参数设置---AMapLocationClientOption，通过这个类可以对定位的相关参数进行设置，在AMapLocationClient进行定位时需要这些参数
         */
        Log.i(TAG, "init: Start---");
        aMapLocationClient = new com.amap.api.location.AMapLocationClient(context.getApplicationContext());//定位服务定位服务类。此类提供单次定位、持续定位、最后位置相关功能
        Log.i(TAG, "定位SDK版本信息：" + aMapLocationClient.getVersion() + "\n");
        aMapLocationClient.setLocationListener(this);//设置定位回调监听
        aMapLocationClientOption = new AMapLocationClientOption();
        aMapLocationClientOption.setSensorEnable(true);//使用传感器
        //aMapLocationClientOption.setGpsFirst(true);//在单次定位高精度定位模式(默认模式)下有效为true时，会等待GPS定位结果返回，最多等待30秒，若30秒后仍无GPS结果返回，返回网络定位结果
        aMapLocationClientOption.setOnceLocation(true);//true--单次定位
        aMapLocationClientOption.setLocationCacheEnable(false); //false--关闭缓存机制
        //aMapLocationClientOption.setOnceLocationLatest(true);//仅适用于单次定位，当设置为true时，连续定位会自动变为单次定位,定位精度会更高，但是定位速度会变慢1-3秒
        //aMapLocationClientOption.setInterval(4000);//连续定位，设置定位间隔,单位毫秒,默认为2000ms，最低1000ms。
        Log.i(TAG, "first定位时间间隔： " + aMapLocationClientOption.getInterval() + "\n");
        aMapLocationClient.setLocationOption(aMapLocationClientOption);
        requestLocation();
        //sdk5.0后
        MyLocationStyle myLocationStyle = new MyLocationStyle();//初始化定位蓝点
        myLocationStyle.myLocationIcon(new com.amap.api.maps.model.BitmapDescriptorFactory().fromResource(R.drawable.navi_map_gps_locked));
        //默认是LOCATION_TYPE_LOCATION_ROTAT 定位、且将视角移动到地图中心点，定位点依照设备方向旋转，并且会跟随设备移动。
        myLocationStyle.myLocationType(MyLocationStyle.LOCATION_TYPE_FOLLOW_NO_CENTER);//连续定位、蓝点不会移动到地图中心点，并且蓝点会跟随设备移动。
        myLocationStyle.showMyLocation(true);//设置是否显示定位小蓝点，用于满足只想使用定位，不想使用定位小蓝点的场景，设置false以后图面上不再有定位蓝点的概念，但是会持续回调位置信息。
        myLocationStyle.strokeWidth(0.0005f);
        myLocationStyle.strokeColor(R.color.radiusFillColor);
        myLocationStyle.radiusFillColor(R.color.radiusFillColor);
        Log.i(TAG, "late,定位时间间隔： " + aMapLocationClientOption.getInterval() + "\n");
        /*if (aMap == null) {
            aMap = mapView.getMap();
        }*/
        aMap.setLocationSource(this);
        aMap.setMyLocationEnabled(true);// 设置定位图层，设置为true表示启动显示定位蓝点
        if (aMap.isMyLocationEnabled())
            Log.i(TAG, "定位源:" + aMap.getMyLocation()/*.toString()+" "+aMap.getMyLocationStyle().toString()*/ + "\n");
        aMap.setMyLocationStyle(myLocationStyle);//设置定位蓝点的Style
        Log.i(TAG, "init: end----------------------------------------------------------------------");
        //aMapLocationClient.stopLocation();
    }

    @Override
    public void setTextview(TextView textview) {
        this.textView = textview;
    }

    /**
     * 请求定位信息
     */
    private void requestLocation() {
        aMapLocationClient.startLocation();
    }

    /**
     * aMapLocationClient.setLocationListener(this);//设置定位回调监听
     * AMapLocationListener中定位回调监听，当定位完成后调用此方法
     */
    @Override
    public void onLocationChanged(AMapLocation aMapLocation) {
        StringBuilder currentPosition = new StringBuilder();
        this.onLocationChangedListener.onLocationChanged(aMapLocation);
        switch (aMapLocation.getErrorCode()) {
            case com.amap.api.location.AMapLocation.LOCATION_SUCCESS:
                Toast.makeText(this.context, "定位成功", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_AIRPLANEMODE_WIFIOFF:
                Toast.makeText(this.context, "定位失败，请连接wifi", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_CELL:
                Toast.makeText(this.context, "定位失败，请打开网络", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_INIT:
                Toast.makeText(this.context, "初始化异常，请重试", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_LOCATION:
                Toast.makeText(this.context, "定位异常，请重试", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_CONNECTION:
                Toast.makeText(this.context, "网络连接异常", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_LOCATION_PERMISSION:
                Toast.makeText(this.context, "缺少定位权限，请设置权限", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_NOENOUGHSATELLITES:
                Toast.makeText(this.context, "GPS定位失败，请稍后重试", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_FAILURE_NOWIFIANDAP:
                Toast.makeText(this.context, "定位失败，请查看网络", Toast.LENGTH_SHORT).show();
                break;
            case com.amap.api.location.AMapLocation.ERROR_CODE_UNKNOWN:
                Toast.makeText(this.context, "未知错误，请稍后重试", Toast.LENGTH_SHORT).show();
                break;
            default:
                break;
        }
        Log.i(TAG, "定位监听中:----> ");
        myLocationlatLongitude = aMapLocation.getLongitude();
        myLocationlatLatitude = aMapLocation.getLatitude();
        this.setMyCity(aMapLocation.getCity());
        this.setMyAdCode(aMapLocation.getAdCode());
        this.setMyCityCode(aMapLocation.getCityCode());
        this.setLatLngOfMyself(myLocationlatLatitude, myLocationlatLongitude);
        this.moveCamera(new LatLng(myLocationlatLatitude, myLocationlatLongitude));
        this.textView.setText(aMapLocation.getAoiName() + "（您" + aMapLocation.getDescription() + "）");
        //new BusPoiManager(this.context,aMap,this.getLatLngOfMyself(),this.getMyCityCode()).busPoiSearchNearby();
        //MyBusPoiManagerSub  busPoiManagerSub=new MyBusPoiManagerSub(this.context,aMap,this.getLatLngOfMyself(),this.getMyAdCode());
        new Thread(new MyBusPoiManagerSub(this.context, aMap, this.getLatLngOfMyself(), this.getMyAdCode())).start();
        /*  busPoiManagerSub.multiPointOverlay();// 绘制麻点图   */
        Log.i(TAG, "定位提供者：" + aMapLocation.getProvider() + " citycode--> " + aMapLocation.getCityCode() + " 所在经度：" + myLocationlatLongitude + " 纬度：" + myLocationlatLatitude + "\n");
        currentPosition.append("POIname:").append(aMapLocation.getPoiName()).append("\n");
        currentPosition.append("经度： ").append(myLocationlatLongitude).append("\n");
        currentPosition.append("纬度： ").append(myLocationlatLatitude).append("\n");
        currentPosition.append("定位方式： ");
        if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_GPS) {
            currentPosition.append("GPS\n");
        } else if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_WIFI) {
            currentPosition.append("wifi定位\n");
        } else if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_LAST_LOCATION_CACHE)
            currentPosition.append("最后缓存定位\n");
        else if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_OFFLINE)
            currentPosition.append("离线定位\n");
        else if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_SAME_REQ)
            currentPosition.append("前次定位\n");
        else if (aMapLocation.getLocationType() == AMapLocation.LOCATION_TYPE_FIX_CACHE)
            currentPosition.append("缓存定位\n");
    }

    /**
     * LocationSource.OnLocationChangedListener
     */
    @Override
    public void onLocationChanged(Location location) {
        if (location != null) {
            Toast.makeText(context, "您的位置：" + location.getLongitude() + " " + location.getLongitude(), Toast.LENGTH_SHORT).show();
            Log.i(TAG, "定位源：" + location.toString() + "\n");
        }
    }

    /**
     * com.amap.api.maps.AMapActivity.OnMyLocationChangeListener
     */
    @Override
    public void onMyLocationChange(Location location) {
        Log.i(TAG, "MyLocationChanged\n");
    }

    /**
     * 接口 com.amap.api.maps.LocationSource + OnLocationChangedListener
     * 激活位置接口，定位程序将通过此接口将主线程广播定位信息，直到用户关闭此通知
     */
    @Override
    public void activate(OnLocationChangedListener onLocationChangedListener) {
        this.onLocationChangedListener = onLocationChangedListener;
    }

    /**
     * 接口 com.amap.api.maps.LocationSource中的方法
     */
    @Override
    public void deactivate() {
    }

    public void moveCamera(LatLng myLatLng) {
        if (myLatLng != null)
            aMap.animateCamera(CameraUpdateFactory.newCameraPosition(new CameraPosition(myLatLng, 16.5f, 0, 0)));//缩放级别15.5（精度越高，可视区域越详细）
        else {
            ToastTools.show(this.context,"定位异常，请重试");
        }
    }

    /**
     *
     */
    public void onDestroy() {
        if (aMapLocationClient != null) {
            aMapLocationClient.onDestroy();
            aMapLocationClient = null;
            aMapLocationClientOption = null;
        }
        Log.i(TAG, "onDestroy: running");
    }


}
