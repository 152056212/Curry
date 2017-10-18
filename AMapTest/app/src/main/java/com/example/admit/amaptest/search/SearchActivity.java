package com.example.admit.amaptest.search;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.widget.TextView;

import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.index.AMapActivity;

/**
 * Created by admit on 2017/7/30.
 */

public class SearchActivity extends AppCompatActivity implements SeachManageable,MyItemOnclickListener{

    private SearchTitleBar searchTitleBar;
    private String myCityName;

    @Override
    protected void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_search);

        Intent intent=getIntent();
        this.setMyCityName(intent.getStringExtra("data_nameOfMycity"));

        searchTitleBar =(SearchTitleBar)findViewById(R.id.seach_activity_title);
        searchTitleBar.setSeachLisener(this);
        searchTitleBar.setMyItemOnclickListener(this);
    }
    public String getMyCityName() {
        return myCityName;
    }

    public void setMyCityName(String myCityName) {
        this.myCityName = myCityName;
    }

    @Override
    public void itemOnclick(View view, SearchTips searchTips) {
        AMapActivity.actionstart(this,'S'+'A',searchTips.getIntro().getPoint().getLatitude(),searchTips.getIntro().getPoint().getLongitude(),searchTips.getIntro().getAdcode());
        this.finish();
    }

    @Override
    public String getCityName() {
        return this.getMyCityName();
    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
    }

    @Override
    protected void onResume() {
        super.onResume();
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
    }

}
