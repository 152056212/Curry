package com.example.admit.amaptest.index;

import com.amap.api.maps.AMap;
import com.amap.api.maps.MapView;

/**
 * Created by admit on 2017/7/26.
 * Manage AMapFragment (接口)
 */

public interface AMapManageable {
    public void getAMap(MapView mapView,AMap aMap,MyLocationManager myLocationManager);
}
