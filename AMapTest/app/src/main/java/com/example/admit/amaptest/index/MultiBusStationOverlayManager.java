package com.example.admit.amaptest.index;

import android.content.Context;

import com.amap.api.services.busline.BusStationItem;

import java.util.ArrayList;

/**
 * Created by admit on 2017/7/22.
 */

public final class MultiBusStationOverlayManager {
    private Context context;
    private String myCityName;
    private ArrayList<BusStationItem>  busStationItems;

    public MultiBusStationOverlayManager(Context context, String myCityName) {

    }

    public Context getContext() {
        return context;
    }

    public void setContext(Context context) {
        this.context = context;
    }

    public String getMyCityName() {
        return myCityName;
    }

    public void setMyCityName(String myCityName) {
        this.myCityName = myCityName;
    }

    public ArrayList<BusStationItem> getBusStationItems() {
        return busStationItems;
    }

    public void setBusStationItems(ArrayList<BusStationItem> busStationItems) {
        this.busStationItems = busStationItems;
    }
}
