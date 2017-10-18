package com.example.admit.amaptest.index;

import android.content.Context;
import android.util.Log;

import com.amap.api.maps.AMap;
import com.amap.api.services.busline.BusLineItem;
import com.amap.api.services.busline.BusLineQuery;
import com.amap.api.services.busline.BusLineResult;
import com.amap.api.services.busline.BusLineSearch;
import com.amap.api.services.busline.BusStationSearch;
import com.example.admit.amaptest.MySchedule.BusLineOverlay;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;

import java.util.ArrayList;
import java.util.List;


public class BusLineSearchManage implements BusLineSearch.OnBusLineSearchListener {
    public static final String TAG = "TAG";

    private Context context;
    private AMap aMap;
    private BusStationSearch busStationSearch;
    private BusLineQuery busLineQuery;
    private List<BusLineItem> busLineItems=new ArrayList<>();

    public BusLineSearchManage(Context context, AMap aMap) {
        this.context = context;
        this.aMap=aMap;
    }

    public void busLineSearch(String query,String cityCode) {

        busLineQuery = new BusLineQuery(query, BusLineQuery.SearchType.BY_LINE_NAME, cityCode);
        busLineQuery.setPageSize(10);
        busLineQuery.setPageNumber(0);
        BusLineSearch busLineSearch = new BusLineSearch(context, busLineQuery);
        busLineSearch.setOnBusLineSearchListener(this);
        busLineSearch.searchBusLineAsyn();
    }
    @Override
     public void onBusLineSearched(BusLineResult result, int rCode) {
        if (rCode == 1000) {
            if (result != null && result.getQuery() != null && result.getQuery().equals(busLineQuery)) {
                //dissmissProgressDialog();
                if (result.getQuery().getCategory() == BusLineQuery.SearchType.BY_LINE_NAME) {
                    if (result.getPageCount() > 0 && result.getBusLines() != null && result.getBusLines().size() > 0) {
                        busLineItems = result.getBusLines();
                        Log.i(TAG, "onBusLineSearched-----------------> 公交站点搜索结果 ");
                        Log.i(TAG, ""+busLineItems.get(0).toString());
                    }
                } else if (result.getQuery().getCategory() == BusLineQuery.SearchType.BY_LINE_ID) {
                    busLineItems = result.getBusLines();
                    BusLineOverlay busLineOverlay = new BusLineOverlay(this.context, aMap, busLineItems.get(0));
                    busLineOverlay.removeFromMap();
                    busLineOverlay.addToMap();
                    busLineOverlay.zoomToSpan();
                }
            } else {
                ToastTools.show(this.context, R.string.no_result);
            }
        } else {
            ToastTools.show(this.context, R.string.error_network);
        }
    }
}
