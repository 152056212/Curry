package com.example.admit.amaptest.index;

import android.content.Context;
import android.graphics.BitmapFactory;
import android.util.Log;

import com.amap.api.maps.AMap;
import com.amap.api.maps.model.BitmapDescriptorFactory;
import com.amap.api.maps.model.LatLng;
import com.amap.api.maps.model.MarkerOptions;
import com.amap.api.maps.model.MultiPointItem;
import com.amap.api.maps.model.MultiPointOverlay;
import com.amap.api.maps.model.MultiPointOverlayOptions;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.core.PoiItem;
import com.amap.api.services.poisearch.PoiResult;
import com.amap.api.services.poisearch.PoiSearch;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;

import java.util.ArrayList;

/**
 * Created by admit on 2017/7/22.
 */

public final class MyBusPoiManagerSub extends MyBusPoiManager implements PoiSearch.OnPoiSearchListener, Runnable {

    private int pageOfCount;
    private int pageOfCountFlag;
    private MultiPointOverlayOptions multiPointOverlayOptions;//海量点的选项类
    private MultiPointOverlay multiPointOverlay;//海量点管理对象
    private ArrayList<MultiPointItem> busePoiList = new ArrayList<MultiPointItem>();
    private boolean isRunning = true;

    public MyBusPoiManagerSub(Context context, AMap aMap, LatLng latLng, String cityCode) {
        super(context, aMap, cityCode);
        this.context = context;
        this.aMap = aMap;
        this.cityCode = cityCode;
        this.setLatLng(latLng);
        this.busPoiSearch(0);
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

    public int getPageOfCount() {
        return pageOfCount;
    }

    public void setPageOfCount(int pageOfCount) {
        this.pageOfCount = pageOfCount;
    }

    public int getPageOfCountFlag() {
        return pageOfCountFlag;
    }

    public void setPageOfCountFlag(int pageOfCountFlag) {
        this.pageOfCountFlag = pageOfCountFlag;
    }


    public ArrayList<MultiPointItem> getBusePoiList() {
        return busePoiList;
    }

    public void onPoiItemSearched(PoiItem poiItem, int i) { }

    public void busPoiSearch(int numberOfPage) {
        /**
         * keyWord表示搜索字符串;
         * 第二个参数表示POI搜索类型，二者选填其一，选用POI搜索类型时建议填写类型代码，码表可以参考下方（而非文字）;
         * cityCode表示POI搜索区域，可以是城市编码也可以是城市名称，也可以传空字符串，空字符串代表全国在全国范围内进行搜索
         */
        this.setPageOfCountFlag(numberOfPage);
        this.setBusQuery(this.Query_String, this.CTGR_BUS_POI, this.cityCode);
        PoiSearch.Query busesPoiSearchQuery = this.getBusQuery();
        busesPoiSearchQuery.setPageSize(30);
        busesPoiSearchQuery.setPageNum(numberOfPage);
        Log.i(TAG, "run: ----> No." + numberOfPage + " 次 ");
        PoiSearch searchBusesPoi = new PoiSearch(this.context, busesPoiSearchQuery);
        searchBusesPoi.setBound(new PoiSearch.SearchBound(new LatLonPoint(this.getLatLng().latitude,this.getLatLng().longitude),5000));
        searchBusesPoi.setOnPoiSearchListener(this);
        searchBusesPoi.searchPOIAsyn();

    }

    public synchronized void onPoiSearched(PoiResult poiResult, int i) {
        this.setPageOfCount(poiResult.getPageCount());
        Log.i(TAG, "onPoiSearche结果总页数：--->" + poiResult.getPageCount());
        if (this.getPageOfCountFlag() != 0) {
            Log.i(TAG, "MyBusPoiManagerSub Running----> 开始");
            Log.i(TAG, " 第 " + this.getPageOfCountFlag() + " 次搜索----------------------------------------------------------------");
            this.setPageOfCount(poiResult.getPageCount());
            if (poiResult == null || i != 1000) {
                ToastTools.show(this.context, "Seach Field");
                Log.i(TAG, " 查询失败 ");
            } else {
                poiList = poiResult.getPois();
                iterator = poiList.iterator();
                iteratorTag = poiList.iterator();
                markerOption = new MarkerOptions();
                int g = 0;
                while (iterator.hasNext()) {
                    subPoiItem = iterator.next();
                    //this.busePoiList.add(new MultiPointItem(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude())));
                    Log.i(TAG, "while:" + "第 " + g + " 个POI的中心距： " + subPoiItem.getDistance()
                            + " Title: " + subPoiItem.getTitle() + "PoiId: " + subPoiItem.getPoiId()
                            + " " + subPoiItem.toString() + " 经度：" + subPoiItem.getLatLonPoint().getLongitude()
                            + " 纬度：" + subPoiItem.getLatLonPoint().getLatitude() + "\n");
                    markerOption.position(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude()));
                    markerOption.icon(BitmapDescriptorFactory.fromBitmap(BitmapFactory.decodeResource(this.context.getResources(), R.drawable.poi_maker_green)));
                    markerOption.isVisible();
                    markerOption.title(subPoiItem.getTitle());
                    markerOption.isInfoWindowEnable();
                    markerOption.draggable(false);
                    markerOption.setFlat(true);
                    markerOption.perspective(true);
                    this.aMap.addMarker(markerOption);
                    g++;
                }
                if (!iterator.hasNext()) {
                    iterator = iteratorTag;
                }
            }
        } else {
            Log.i(TAG, " 第 " + this.getPageOfCountFlag() + " 次搜索------------------------------------------------------------------");
        }
    }

    @Override
    public void run() {
        while (isRunning) {
            try {
                Thread.sleep(900);
                Log.i(TAG, "run---> 总数： " + this.getPageOfCount());
                for (int i = 1; i <= this.getPageOfCount(); i++) {
                    busPoiSearch(i);
                    if (i == this.getPageOfCount()) {
                        isRunning = false;
                    }
                }
            } catch (InterruptedException e) {
                e.printStackTrace();
                Log.i(TAG, "run: 出现异常---end");
            }
        }
        //this.multiPointOverlay();
    }
    /*
    *//**
     * 绘制麻点图
     *//*
    public void multiPointOverlay(){
        multiPointOverlayOptions = new MultiPointOverlayOptions();
        multiPointOverlayOptions.icon(BitmapDescriptorFactory.fromBitmap(BitmapFactory.decodeResource(this.context.getResources(), R.drawable.poi_marker_buses)));//设置图标
        multiPointOverlayOptions.anchor(0.5f,0.5f); //设置锚点
        multiPointOverlay = this.aMap.addMultiPointOverlay(multiPointOverlayOptions);
        multiPointOverlay.setItems(this.getBusePoiList());
    } */
}
