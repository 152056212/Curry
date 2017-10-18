package com.example.admit.amaptest.index;

import android.content.Context;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.ImageButton;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.amap.api.services.busline.BusLineItem;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.busStaionIntro.BusLineItemInfro;
import com.example.admit.amaptest.busStaionIntro.LocationIntroActivity;
import com.example.admit.amaptest.busStaionIntro.ViewpagerManage;

import java.util.ArrayList;
import java.util.List;

/**
 * regard viewpager_busstaion.xml as view
 */

public class BusLineItemViewpager extends RelativeLayout implements View.OnClickListener,ViewpagerManage {

    private TextView title;
    private TextView intro;
    private RecyclerView recyclerView;
    private ImageButton imageButton;
    private List<BusLineItem> busLineItems;
    private List<String> busLineItemName = new ArrayList<>();


    public BusLineItemViewpager(Context context) {
        super(context);
        LayoutInflater.from(context).inflate(R.layout.viewpager_busstaion,this);
        title=(TextView)findViewById(R.id.title);
        intro=(TextView)findViewById(R.id.intro);
        recyclerView=(RecyclerView)findViewById(R.id.busline_recycler_view);
        imageButton=(ImageButton) findViewById(R.id.imgbtn_next);
        title.setOnClickListener(this);
        intro.setOnClickListener(this);
        initBusLineItems();
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(context);
        linearLayoutManager.setOrientation(LinearLayoutManager.HORIZONTAL);
        recyclerView.setLayoutManager(linearLayoutManager);

        BusLinesAdapter adapter = new BusLinesAdapter(busLineItemName);
        recyclerView.setAdapter(adapter);
    }
    private void initBusLineItems() {
        for (int i = 0; i < 1; i++) {
            busLineItemName.add("No." + i);
        }
    }

    /**
     * MyBusPoiManager implements ViewpagerManageable
     */
    public void setViewpager (ViewpagerManageable viewpagerManageable,int countOfViewpager,int numOfViewPager){
        Log.i("TAG", "setViewpager---------------> 把第 "+countOfViewpager+" 页的三个控件进行设置");
        viewpagerManageable.setTitleText(this.title,countOfViewpager);
        viewpagerManageable.setIntroText(this.intro,countOfViewpager);
        viewpagerManageable.setRecylerView(this.recyclerView,countOfViewpager);
        viewpagerManageable.setViewPager(this,countOfViewpager);
        if((countOfViewpager+1)==numOfViewPager){
            this.imageButton.setVisibility(View.GONE);
        }
    }

    @Override
    public void getBusLineList(List<BusLineItem> busLineItems) {
        this.busLineItems=busLineItems;
    }

    @Override
    public void onClick(View v) {
        if(v.getId()==R.id.title){
            LocationIntroActivity.actionStart(getContext(),title.getText().toString(),new BusLineItemInfro(this.busLineItems));
        }
        if(v.getId()==R.id.intro){
            LocationIntroActivity.actionStart(getContext(),title.getText().toString(),new BusLineItemInfro(this.busLineItems));
        }
    }
}
