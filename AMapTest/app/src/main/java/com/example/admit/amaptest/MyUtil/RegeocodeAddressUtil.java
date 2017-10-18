package com.example.admit.amaptest.MyUtil;

import android.content.Context;
import android.util.Log;

import com.amap.api.maps.AMap;
import com.amap.api.maps.model.LatLng;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.geocoder.GeocodeResult;
import com.amap.api.services.geocoder.GeocodeSearch;
import com.amap.api.services.geocoder.RegeocodeQuery;
import com.amap.api.services.geocoder.RegeocodeResult;
import com.example.admit.amaptest.index.BusPoiManager;

/**
 * Created by admit on 2017/7/23.
 * 逆地理编码(坐标转地址)
 */

public final class RegeocodeAddressUtil implements GeocodeSearch.OnGeocodeSearchListener{

    private Context context;
    private String myCityCode;
    private double latitude;
    private double longitude;
    private AMap aMap;

    public double getLongitude() { return longitude; }
    public void setLongitude(double longitude) { this.longitude = longitude; }
    public double getLatitude() { return latitude; }
    public void setLatitude(double latitude) { this.latitude = latitude;}
    public Context getContext() { return context; }
    public void setContext(Context context) { this.context = context; }
    public String getMyCityCode() { return myCityCode; }
    public void setMyCityCode(String myCityCode) { this.myCityCode = myCityCode; }
    public AMap getaMap() { return aMap; }
    public void setaMap(AMap aMap) { this.aMap = aMap;}

    public void setADCode(Context context, AMap aMap,double latitude, double longitude) {
        this.setContext(context);
        this.setaMap(aMap);
        this.setLatitude(latitude);
        this.setLongitude(longitude);
        Log.i("TAG", "getADCode-----------> start");
        // 第一个参数表示一个Latlng，第二参数表示范围多少米，第三个参数表示是火系坐标系还是GPS原生坐标系
        RegeocodeQuery query = new RegeocodeQuery(new LatLonPoint(latitude, longitude), 90000, GeocodeSearch.AMAP);
        GeocodeSearch geocoderSearch = new GeocodeSearch(context);
        geocoderSearch.getFromLocationAsyn(query);
        geocoderSearch.setOnGeocodeSearchListener(this);
        Log.i("TAG", "getADCode-----------> end");
    }
    @Override
    public synchronized void onRegeocodeSearched(RegeocodeResult regeocodeResult, int i) {
        if (regeocodeResult!=null && i==1000) {
            Log.i("TAG", "getADCode-----------> starting");
            this.setMyCityCode(regeocodeResult.getRegeocodeAddress().getAdCode());
            new BusPoiManager(this.getContext(),this.getaMap(),new LatLng(this.getLatitude(),this.getLongitude()),regeocodeResult.getRegeocodeAddress().getAdCode()).busPoiSearchNearby();

        } else {
            this.setMyCityCode("Search Error");
        }
    }
    @Override
    public void onGeocodeSearched(GeocodeResult geocodeResult, int i) { }
}
