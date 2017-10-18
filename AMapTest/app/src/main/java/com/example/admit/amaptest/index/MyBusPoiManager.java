package com.example.admit.amaptest.index;

import android.content.Context;
import android.graphics.BitmapFactory;
import android.support.v4.view.ViewPager;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.View;
import android.widget.TextView;


import com.amap.api.maps.AMap;
import com.amap.api.maps.model.BitmapDescriptorFactory;
import com.amap.api.maps.model.LatLng;
import com.amap.api.maps.model.MarkerOptions;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.core.PoiItem;
import com.amap.api.services.poisearch.PoiResult;
import com.amap.api.services.poisearch.PoiSearch;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.busStaionIntro.BusStationSearchManager;

import java.util.ArrayList;
import java.util.List;

public class MyBusPoiManager extends BusPoiManager implements PoiSearch.OnPoiSearchListener, ViewpagerManageable {
    /* protected static final String TAG = "TAG";
     protected final String Query_String = "公交车站";
     protected final String CTGR_BUS_POI = "150700";
     protected Context context;
     protected AMap aMap;
     protected LatLng latLng;
     protected String cityCode;
     protected PoiSearch.Query busQuery;
     protected ArrayList<PoiItem> poiList;
     protected Iterator<PoiItem> iterator;
     protected Iterator<PoiItem> iteratorTag;
     protected MarkerOptions markerOption;
     protected PoiItem subPoiItem;
     private Text text;
     private TextOptions textOptions;*/
    public final List<LatLonPoint> myBusStations = new ArrayList<>();
    private List<TextView> titles = new ArrayList<>();
    private List<TextView> intros = new ArrayList<>();
    private List<RecyclerView> recyclerViews = new ArrayList<>();
    private List<TextView> data = new ArrayList<>();
    private List<BusLineItemViewpager> busLineItemViewpagers=new ArrayList<>();
    private List<View> viewContainer = new ArrayList<>();
    private MyBusPoiManager myBusPoiManager;
    private ViewpagerManageable viewpagerManageable;
    private boolean SEARCH_NEARBY=false;

    public MyBusPoiManager() {
        super();
    }

    public MyBusPoiManager(Context context, AMap aMap, LatLng latLng) {
        super(context, aMap, latLng);
    }

    public MyBusPoiManager(Context context, AMap aMap, String cityCode) {
        super(context, aMap, cityCode);
    }

    public MyBusPoiManager(Context context, AMap aMap, LatLng latLng, String cityCode) {
        super(context, aMap, latLng, cityCode);
    }

    public PoiSearch.Query getBusQuery() {
        return busQuery;
    }

    public LatLng getLatLng() {
        return latLng;
    }

    public void setLatLng(LatLng latLng) {
        this.latLng = latLng;
    }

    public void setBusQuery(String query, String ctgr, String cityCode) {
        this.busQuery = new PoiSearch.Query(query, ctgr, cityCode);
    }

    @Override
    public void onPoiItemSearched(PoiItem poiItem, int i) {
    }

    public void busPoiSearchNearby(ViewpagerManageable viewpagerManageable,MyBusPoiManager myBusPoiManager,List<View> viewContainer) {
        super.busPoiSearchNearby();
        this.SEARCH_NEARBY=true;
        this.viewpagerManageable=viewpagerManageable;
        this.myBusPoiManager=myBusPoiManager;
        this.viewContainer=viewContainer;
    }

    @Override
    public void onPoiSearched(PoiResult poiResult, int i) {
        if (i == 1000 && poiResult != null) {//i==1000:SearchSucessed；
            int[] poiMakersId = {R.drawable.poi_marker_1, R.drawable.poi_marker_2,
                    R.drawable.poi_marker_3, R.drawable.poi_marker_4,
                    R.drawable.poi_marker_5, R.drawable.poi_marker_6,
                    R.drawable.poi_marker_7, R.drawable.poi_marker_8,
                    R.drawable.poi_marker_9, R.drawable.poi_marker_10,
            };
            Log.i(TAG, "onPoiSearched:搜索——-->" + "总页数： " + poiResult.getPageCount() + "\n");
            if(poiResult.getPageCount()==0){
                ToastTools.show(this.context,"查询结果为空！");
            }else {
                poiList = poiResult.getPois();
                iterator = poiList.iterator();
                iteratorTag = poiList.iterator();
                markerOption = new MarkerOptions();
                //textOptions = new TextOptions();
                if (this.SEARCH_NEARBY)
                    for (int k = 0; k < poiList.size(); k++) {
                        Log.i(TAG, "onClick点击后，创建第 " + i + " 页");
                        BusLineItemViewpager busLineItemViewpager = new BusLineItemViewpager(this.context);
                        busLineItemViewpager.setViewpager(this.myBusPoiManager, k, poiList.size());
                        viewContainer.add(busLineItemViewpager);
                    }
                int g = 0;
                while (iterator.hasNext()) {
                    subPoiItem = iterator.next();
                    myBusStations.add(subPoiItem.getLatLonPoint());
                    Log.i(TAG, "while:" + "第 " + g + " 个POI的中心距： " + subPoiItem.getDistance()
                            + " Title: " + subPoiItem.getTitle() + "PoiId: " + subPoiItem.getPoiId()
                            + " " + subPoiItem.toString() + " 经度：" + subPoiItem.getLatLonPoint().getLongitude()
                            + " 纬度：" + subPoiItem.getLatLonPoint().getLatitude() + "\n");
                    int k = g + 1;
                    this.titles.get(g).setText(k + "." + subPoiItem.getTitle());
                    this.intros.get(g).setText("距您大概：" + subPoiItem.getDistance() + "米");
                    //this.data.get(g).setText(subPoiItem.getAdCode());
                    //new BusStationSearchManager(AMapActivity)
                    Log.i(TAG, "开始搜索站点：" + subPoiItem.getTitle() + " 的途径线路-------------------------------> ");
                    BusStationSearchManager busStationSearchManager = new BusStationSearchManager(this.context);
                    busStationSearchManager.setViewpagerManage(this.busLineItemViewpagers.get(g));
                    busStationSearchManager.busStationSearch(subPoiItem.getTitle(), subPoiItem.getAdCode());
                    busStationSearchManager.setRecyclerView(this.recyclerViews.get(g), LinearLayoutManager.HORIZONTAL);
                    Log.i(TAG, "结束搜索站点：" + subPoiItem.getTitle() + " 的途径线路-------------------------------> ");
                /*TextOptions textOptions = new TextOptions();
                textOptions.visible(true);
                Text text = this.aMap.addText(textOptions);
                text.setPosition(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude()));
                text.setText(subPoiItem.getTitle());
                text.setVisible(true);*/
                    markerOption.position(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude()));
                    markerOption.icon(BitmapDescriptorFactory.fromBitmap(BitmapFactory.decodeResource(this.context.getResources(), poiMakersId[g])));
                    markerOption.isVisible();
                    markerOption.title(subPoiItem.getTitle());
                    markerOption.isInfoWindowEnable();
                    markerOption.draggable(false);//设置Marker可拖动
                    markerOption.setFlat(true);//设置marker平贴地图效果
                    markerOption.perspective(true);
                    aMap.addMarker(markerOption);
                    Log.i(TAG, "maker " + markerOption.getTitle() + "\n");
                    g++;
                }
                if (this.SEARCH_NEARBY)
                    this.viewpagerManageable.setViewPager(this.myBusPoiManager,new MyViewPagerAdapter(this.viewContainer));
                if (!iterator.hasNext()) {
                    iterator = iteratorTag;
                }
            }
        } else {
            ToastTools.show(this.context, "Search Filed");
        }
    }

    @Override
    public void setTitleText(TextView textView, int numOfViewpager) {
        this.titles.add(textView);
    }

    @Override
    public void setIntroText(TextView textView, int numOfViewpager) {
        this.intros.add(textView);
    }

    @Override
    public void setRecylerView(RecyclerView recylerView, int numOfViewpager) {this.recyclerViews.add(recylerView);}

    @Override
    public void setViewPager(BusLineItemViewpager busLineItemViewpager, int numOfView) {
        this.busLineItemViewpagers.add(busLineItemViewpager);
    }
    @Override
    public void setViewPager(MyBusPoiManager busPoiManager,MyViewPagerAdapter myViewPagerAdapter) { }
}

