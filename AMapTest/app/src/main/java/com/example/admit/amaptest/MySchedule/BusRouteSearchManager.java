package com.example.admit.amaptest.MySchedule;


import android.content.Context;
import android.util.Log;

import com.amap.api.maps.AMap;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.route.BusPath;
import com.amap.api.services.route.BusRouteResult;
import com.amap.api.services.route.BusStep;
import com.amap.api.services.route.DriveRouteResult;
import com.amap.api.services.route.RideRouteResult;
import com.amap.api.services.route.RouteSearch;
import com.amap.api.services.route.WalkRouteResult;
import com.example.admit.amaptest.MyUtil.ToastTools;

import java.util.List;

public class BusRouteSearchManager implements RouteSearch.OnRouteSearchListener {

    private static final String TAG = "TAG";
    private Context context;
    private AMap aMap;
    private LatLonPoint from;
    private LatLonPoint to;
    private int mode;
    private String cityName;
    private int nightFlag;
    private RouteSearch.BusRouteQuery busRouteQuery;
    private List<BusPath> busPaths;
    private List<BusStep> busSteps;

    public BusRouteSearchManager(Context context, AMap aMap, LatLonPoint from, LatLonPoint to, int mode, String city, int nightFlag) {
        this.context = context;
        this.aMap = aMap;
        this.from = from;
        this.to = to;
        this.mode = mode;
        this.cityName = city;
        this.nightFlag = nightFlag;
    }

    public RouteSearch.FromAndTo getFromAndTo(LatLonPoint from, LatLonPoint to) {
        return new RouteSearch.FromAndTo(from, to);
    }

    public void init() {
        this.aMap.clear(true);
        RouteSearch routeSearch = new RouteSearch(this.context);
        routeSearch.setRouteSearchListener(this);
        busRouteQuery = new RouteSearch.BusRouteQuery(this.getFromAndTo(this.from, this.to), this.mode, this.cityName, this.nightFlag);
        routeSearch.calculateBusRouteAsyn(busRouteQuery);//开始规划路径
    }

    @Override
    public void onBusRouteSearched(BusRouteResult busRouteResult, int rcode) {
        if (rcode == 1000) {
            this.busPaths = busRouteResult.getPaths();
            if (busPaths.size() != 0)
                new BusRouteOverlay(this.context, this.aMap, busPaths.get(0), this.from, this.to).addToMap();
            else ToastTools.show(this.context, "对不起，查询结果为空！");
        } else ToastTools.show(this.context, "查询失败");
    }

    @Override
    public void onDriveRouteSearched(DriveRouteResult driveRouteResult, int i) {
    }

    @Override
    public void onRideRouteSearched(RideRouteResult rideRouteResult, int i) {
    }

    @Override
    public void onWalkRouteSearched(WalkRouteResult walkRouteResult, int i) {
    }
}
