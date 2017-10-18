package com.example.admit.amaptest.busStaionIntro;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.widget.ImageButton;
import android.widget.TextView;

import com.amap.api.services.busline.BusLineItem;
import com.amap.api.services.busline.BusStationItem;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.search.MyDecoration;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;


public class LocationIntroActivity extends AppCompatActivity implements View.OnClickListener {

    private ImageButton imageButton;
    private TextView textView;
    private List<String> busLineName = new ArrayList<>();
    private RecyclerView recyclerView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_busstation_intro);
        imageButton = (ImageButton) findViewById(R.id.btn_intro_return);
        textView = (TextView) findViewById(R.id.tv_location_name);
        recyclerView = (RecyclerView) findViewById(R.id.intro_recycler_view);
        imageButton.setOnClickListener(this);

        Intent intent = getIntent();
        String stationName = intent.getStringExtra("BusStationName");
        BusLineItemInfro busLineItemInfro = intent.getParcelableExtra("BusLineItemInfro");
        List<BusLineItem> busLineItem = busLineItemInfro.getBusLineItems();
        Iterator<BusLineItem> iterator = busLineItem.iterator();
        while (iterator.hasNext()) {
            if (iterator != null)
                Log.i("TAG", "接收结果--------------------------> " + iterator.next().getBusStations().size());
        }
        for (int i=0;i<busLineItem.size();i++){
            String temp=busLineItem.get(i).toString();
            busLineName.add(temp.substring(0,temp.length()-2));
        }
        textView.setText(stationName);

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(LocationIntroActivity.this);
        linearLayoutManager.setOrientation(LinearLayoutManager.VERTICAL);
        recyclerView.setLayoutManager(linearLayoutManager);
        this.recyclerView.setAdapter(new BusLineItemAdapter(busLineName));
        this.recyclerView.addItemDecoration(new MyDecoration(LocationIntroActivity.this, MyDecoration.VERTICAL_LIST));


    }

    @Override
    public void onClick(View v) {
        if (v.getId() == R.id.btn_intro_return) {
            finish();
        }
    }

    public static void actionStart(Context context, String busStationName, BusLineItemInfro busLineItem) {
        Intent intent = new Intent(context, LocationIntroActivity.class);
        intent.putExtra("BusStationName", busStationName);
        intent.putExtra("BusLineItemInfro", busLineItem);
        intent.setExtrasClassLoader(BusLineItem.class.getClassLoader());
        context.startActivity(intent);
    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
    }

    @Override
    protected void onPause() {
        super.onPause();
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
