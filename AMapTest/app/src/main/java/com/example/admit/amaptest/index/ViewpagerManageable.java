package com.example.admit.amaptest.index;

import android.support.v4.view.ViewPager;
import android.support.v7.widget.RecyclerView;
import android.widget.TextView;

/**
 * Created by admit on 2017/7/30.
 */

public interface ViewpagerManageable {
    public void setTitleText(TextView textView,int numOfView);
    public void setIntroText(TextView textView,int numOfView);
    public void setRecylerView(RecyclerView recylerView,int numOfView);
    public void setViewPager(BusLineItemViewpager busLineItemViewpager,int numOfView);
    public void setViewPager(MyBusPoiManager busPoiManager,MyViewPagerAdapter myViewPagerAdapter);
}
