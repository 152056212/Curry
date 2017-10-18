package com.example.admit.amaptest.MySchedule;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.LayoutRes;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import com.amap.api.services.core.AMapException;
import com.amap.api.services.help.Inputtips;
import com.amap.api.services.help.InputtipsQuery;
import com.amap.api.services.help.Tip;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.MyUtil.ViewGroupAnimator;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.index.AMapActivity;
import com.example.admit.amaptest.search.ItemsAdapter;
import com.example.admit.amaptest.search.MyDecoration;
import com.example.admit.amaptest.search.MyItemOnclickListener;
import com.example.admit.amaptest.search.SearchTips;

import java.util.ArrayList;
import java.util.List;


public class MyScheduleActivity extends AppCompatActivity implements MyItemOnclickListener,View.OnClickListener,TextWatcher,Inputtips.InputtipsListener{

    private Button btnReturn;
    private AutoCompleteTextView autoCompleteTextView;
    private Button btnDelete;
    private Button btnSpeech;
    private Button btnMyLocation;
    private Button btnMyCollection;
    private Button btnMapMaker;
    private Button btnHistoryText;
    private RecyclerView recyclerViewHistory;
    private RecyclerView recyclerViewSearch;
    private String myCityName;
    private ItemsAdapter itemsAdapter;

    @Override
    protected void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_route_schedule);

        btnReturn=(Button) findViewById(R.id.btn_search_return);
        autoCompleteTextView=(AutoCompleteTextView)findViewById(R.id.tv_input);
        btnDelete=(Button) findViewById(R.id.btn_delete);
        btnSpeech=(Button) findViewById(R.id.btn_speech);
        btnMyLocation=(Button) findViewById(R.id.btn_mylocation);
        btnMyCollection=(Button) findViewById(R.id.btn_mycollection);
        btnMapMaker=(Button) findViewById(R.id.btn_mymaker);
        btnHistoryText=(Button) findViewById(R.id.btn_text_history);
        recyclerViewHistory=(RecyclerView)findViewById(R.id.recycler_view_history);
        recyclerViewSearch=(RecyclerView)findViewById(R.id.recycler_view_search);
        LinearLayoutManager linearLayout=new LinearLayoutManager(MyScheduleActivity.this);
        linearLayout.setOrientation(LinearLayoutManager.VERTICAL);
        recyclerViewSearch.setLayoutManager(linearLayout);

        btnReturn.setOnClickListener(this);
        autoCompleteTextView.setOnClickListener(this);
        setAutoCompleteTextView(autoCompleteTextView);
        btnDelete.setOnClickListener(this);
        btnSpeech.setOnClickListener(this);
        btnMyLocation.setOnClickListener(this);
        btnMyCollection.setOnClickListener(this);
        btnMapMaker.setOnClickListener(this);
        btnHistoryText.setOnClickListener(this);

        Intent intent=getIntent();
        this.myCityName=intent.getStringExtra("CityName");


    }
    @Override
    public void onClick(View v) {
      switch (v.getId()){
          case R.id.btn_search_return:
              this.finish();
              break;
          case R.id.btn_delete:
              break;
          case R.id.btn_speech:
              break;
          case R.id.btn_mylocation:
              break;
          case R.id.btn_mycollection:
              break;
          case R.id.btn_mymaker:
              break;
          case R.id.btn_text_history:
              break;
      };
    }
    public void setAutoCompleteTextView(AutoCompleteTextView autoCompleteTextView){
        autoCompleteTextView.addTextChangedListener(this);
    }
    @Override
    public void beforeTextChanged(CharSequence s, int start, int count, int after) { }
    @Override
    public void afterTextChanged(Editable s) { }
    @Override
    public void onTextChanged(CharSequence s, int start, int before, int count) {
        if(s==null || s.length()==0 || s.equals("")){
            recyclerViewSearch.setVisibility(View.GONE);
        }else {
            recyclerViewSearch.setVisibility(View.VISIBLE);
            String newText = s.toString();
            InputtipsQuery inputtipsQuery = new InputtipsQuery(newText, myCityName);
            Inputtips inputtips = new Inputtips(MyScheduleActivity.this, inputtipsQuery);
            inputtips.requestInputtipsAsyn();
            inputtips.setInputtipsListener(this);
        }
    }
    @Override
    public void onGetInputtips(List<Tip> tipList, int rCode) {
        Log.i("TAG", "onGetInputtips--------------> 获取结果中 "+tipList.size());
        List<SearchTips> listTips = new ArrayList<SearchTips>();
        for (int i = 0; i < tipList.size(); i++) {
            listTips.add(new SearchTips(R.drawable.tip_icon1, tipList.get(i)));
        }
        itemsAdapter = new ItemsAdapter(this,listTips);
        recyclerViewSearch.setAdapter(itemsAdapter);
        recyclerViewSearch.addItemDecoration(new MyDecoration(MyScheduleActivity.this, MyDecoration.VERTICAL_LIST));
        itemsAdapter.notifyDataSetChanged();
    }

    @Override
    public void itemOnclick(View view, SearchTips searchTips) {
        if(searchTips.getIntro().getPoint()!=null){
           AMapActivity.actionstart(MyScheduleActivity.this,0+'M'+'S'+'A',
                                searchTips.getIntro().getPoint().getLatitude(),
                                searchTips.getIntro().getPoint().getLongitude(),
                                ((TextView)view).getText().toString()+"/"+searchTips.getIntro().getAdcode()
           );
           this.finish();
        }else ToastTools.show(MyScheduleActivity.this,"请选择更具体的地点！");
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
