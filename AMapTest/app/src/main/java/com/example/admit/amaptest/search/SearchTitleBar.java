package com.example.admit.amaptest.search;

import android.app.Activity;
import android.content.Context;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.AttributeSet;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.LinearLayout;

import com.amap.api.services.core.AMapException;
import com.amap.api.services.help.Inputtips;
import com.amap.api.services.help.InputtipsQuery;
import com.amap.api.services.help.Tip;
import com.example.admit.amaptest.R;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by admit on 2017/7/30.
 */

public class SearchTitleBar extends LinearLayout implements View.OnClickListener, TextWatcher, Inputtips.InputtipsListener {

    public static final String TAG = "TAG";
    private ImageButton returnbutton;
    private ImageButton searchbutton;
    private AutoCompleteTextView autoCompleteTextView;
    private Button deletbtn;
    private Button mycitybtn;
    private SeachManageable seachManageable;
    private RecyclerView recyclerView;
    private ItemsAdapter adapter;
    private MyItemOnclickListener myItemOnclickListener;

    public SearchTitleBar(Context context, final AttributeSet attrs) {
        super(context, attrs);
        View view = LayoutInflater.from(context).inflate(R.layout.activity_search_title, this);
        returnbutton = (ImageButton) view.findViewById(R.id.btn_search_return);
        searchbutton = (ImageButton) view.findViewById(R.id.imgbtn_search);
        autoCompleteTextView = (AutoCompleteTextView) view.findViewById(R.id.tv_input);
        deletbtn = (Button) view.findViewById(R.id.btn_delete);
        mycitybtn = (Button) view.findViewById(R.id.btn_mycity);
        recyclerView = (RecyclerView) view.findViewById(R.id.tips_recycler_view);
        LinearLayoutManager linearLayout = new LinearLayoutManager(context);
        linearLayout.setOrientation(LinearLayoutManager.VERTICAL);
        recyclerView.setLayoutManager(linearLayout);

        returnbutton.setOnClickListener(this);
        searchbutton.setOnClickListener(this);
        autoCompleteTextView.setOnClickListener(this);
        deletbtn.setOnClickListener(this);
        mycitybtn.setOnClickListener(this);

        //  输入提示的监听接口
        autoCompleteTextView.addTextChangedListener(this);
    }

    public void beforeTextChanged(CharSequence s, int start, int count, int after) {
    }

    // 输入信息改变之后     p
    public void afterTextChanged(Editable editable) {

    }

    // 正在输入
    public void onTextChanged(CharSequence s, int start, int before, int count) {
        if (s.equals("")) {
            recyclerView.setVisibility(View.GONE);
        } else {
            recyclerView.setVisibility(View.VISIBLE);
            String newText = s.toString();
            // 输入信息的回调方法
            InputtipsQuery inputtipsQuery = new InputtipsQuery(newText, mycitybtn.getText().toString());
            Inputtips inputtips = new Inputtips(getContext(), inputtipsQuery);
            inputtips.requestInputtipsAsyn();
            inputtips.setInputtipsListener(this);
        }
    }

    @Override
    public void onGetInputtips(List<Tip> tipList, int rCode) {
        Log.i(TAG, "onGetInputtips--------------> 获取结果中");
        List<SearchTips> listTips = new ArrayList<SearchTips>();
        for (int i = 0; i < tipList.size(); i++) {
            listTips.add(new SearchTips(R.drawable.tip_icon1, tipList.get(i)));
        }
        adapter = new ItemsAdapter(myItemOnclickListener, listTips);
        recyclerView.setAdapter(adapter);
        recyclerView.addItemDecoration(new MyDecoration(getContext(), MyDecoration.VERTICAL_LIST));
        adapter.notifyDataSetChanged();
    }

    public void setMyItemOnclickListener(MyItemOnclickListener myItemOnclickListener) {
        this.myItemOnclickListener = myItemOnclickListener;
    }

    @Override
    public void onClick(View v) {
        int id = v.getId();
        switch (id) {
            case R.id.btn_search_return:
                ((Activity) getContext()).finish();
                break;
            case R.id.imgbtn_search:
                break;
            case R.id.tv_input:
                break;
            case R.id.btn_delete:

                break;
            case R.id.btn_mycity:

                break;
            default:
                break;
        }
        ;
    }

    public void setSeachLisener(SeachManageable seachManageable) {
        this.seachManageable = seachManageable;
        this.mycitybtn.setText(seachManageable.getCityName());
    }
}
