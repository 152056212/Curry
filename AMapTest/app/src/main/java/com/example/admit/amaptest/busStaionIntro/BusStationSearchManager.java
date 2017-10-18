package com.example.admit.amaptest.busStaionIntro;

import android.content.Context;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;

import com.amap.api.services.busline.BusLineItem;
import com.amap.api.services.busline.BusStationItem;
import com.amap.api.services.busline.BusStationQuery;
import com.amap.api.services.busline.BusStationResult;
import com.amap.api.services.busline.BusStationSearch;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.index.*;
import com.example.admit.amaptest.search.MyDecoration;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by admit on 2017/8/3.
 */

public class BusStationSearchManager implements BusStationSearch.OnBusStationSearchListener {
    public static final String TAG = "TAG";
    private Context context;
    private String stationName;
    private String code;
    private BusStationQuery busStationQuery;
    private BusStationSearch busStationSearch;
    private List<BusLineItem> busLineItems = new ArrayList<>();
    private List<BusStationItem> busStationItems = new ArrayList<>();
    private List<String> busLineName = new ArrayList<>();
    private RecyclerView recyclerView;
    private int RECYCLERVIEW_LAYOUT_TYPE;
    private ViewpagerManage viewpagerClickListener;


    public BusStationSearchManager(Context context) {
        this.context = context;
    }

    public void busStationSearch(String query, String city) {
        this.stationName = query;
        this.code = city;
        busStationQuery = new BusStationQuery(query, city);
        busStationQuery.setPageSize(10);
        busStationQuery.setPageNumber(0);
        busStationSearch = new BusStationSearch(this.context, busStationQuery);
        busStationSearch.setOnBusStationSearchListener(this);
        busStationSearch.searchBusStationAsyn();
    }

    public void setRecyclerView(RecyclerView recyclerView, int type) {
        this.recyclerView = recyclerView;
        this.RECYCLERVIEW_LAYOUT_TYPE = type;
    }

    /**
     * BusLineItemViewpager implements ViewpagerManage
     */
    public void setViewpagerManage(ViewpagerManage viewpagerClickListener) {
        this.viewpagerClickListener = viewpagerClickListener;

    }

    @Override
    public void onBusStationSearched(BusStationResult result, int rCode) {
        if (rCode == 1000) {
            if (result != null && result.getQuery() != null && result.getQuery().equals(busStationQuery)) {
                //dissmissProgressDialog();
                if (result.getPageCount() > 0 && result.getBusStations() != null && result.getBusStations().size() > 0) {
                    //站点类集合
                    busStationItems = result.getBusStations();
                    Log.i(TAG, "onBusStationSearched-------------------> 搜索查询站点结果：" + busStationItems.size() + this.stationName + " " + this.code);
                    //途径站点线路类集合
                    busLineItems = busStationItems.get(0).getBusLineItems();
                    if(busLineItems.isEmpty())
                        ToastTools.show(this.context,"查询结果为空");
                    int size = 0;
                    if (busLineItems.size() % 2 == 0)
                        size = busLineItems.size() / 2;
                    else
                        size = busLineItems.size();
                    for (int i = 0; i < size; i++) {
                        Log.i("TAG", "总线路---------------------->   " + i + " " + busLineItems.get(i).getBusLineName() + " " + busLineItems.get(i).getBusLineType());
                        busLineName.add(busLineItems.get(i).getBusLineName());
                    }
                    this.viewpagerClickListener.getBusLineList(busLineItems);
                    LinearLayoutManager linearLayoutManager = new LinearLayoutManager(context);
                    linearLayoutManager.setOrientation(this.RECYCLERVIEW_LAYOUT_TYPE);
                    recyclerView.setLayoutManager(linearLayoutManager);
                    if (this.RECYCLERVIEW_LAYOUT_TYPE == LinearLayoutManager.VERTICAL) {
                        this.recyclerView.setAdapter(new BusLineItemAdapter(busLineName));
                        this.recyclerView.addItemDecoration(new MyDecoration(this.context, MyDecoration.VERTICAL_LIST));
                    } else {
                        this.recyclerView.setAdapter(new BusLinesAdapter(busLineName));
                    }
                }
            } else {
                ToastTools.show(this.context, R.string.no_result);
            }
        } else {
            ToastTools.show(this.context, R.string.error_network);
        }
    }
}
