package com.example.admit.amaptest.index;

import android.content.Context;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.view.ViewPager;
import android.util.Log;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.KeyEvent;

import com.amap.api.maps.AMap;
import com.amap.api.maps.AMapOptions;
import com.amap.api.maps.MapView;
import com.amap.api.maps.UiSettings;
import com.example.admit.amaptest.R;

/**
 * manage AMap
 */

public class AMapFragment extends Fragment {
    public static final String TAG = "TAG";
    private MapView mapView;
    private AMap aMap;
    private MyLocationManager myLocationManager;

    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
        Log.i(TAG, "fragment onAttach ------>");
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.i(TAG, "fragment onCreate -------->" + this.getTag());
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_amap, container, false);
        mapView = (MapView) view.findViewById(R.id.map);
        mapView.onCreate(savedInstanceState);
        new AMapOptions().compassEnabled(true);
        if (aMap == null) {
            aMap = mapView.getMap();
        }
        myLocationManager = new MyLocationManager(getActivity(), mapView, aMap);
        myLocationManager.initMyLocation();
        aMap.setOnMapClickListener((AMapActivity) getActivity());
        ((AMapActivity) getActivity()).operateAMap();
        ((AMapActivity) getActivity()).showMyLocation(myLocationManager);
        Log.i(TAG, "fragment onCreateView --------> 结束");
        return view;
    }

    public void returnAMap(AMapManageable aMapManageListener) {
        aMapManageListener.getAMap(mapView, aMap, myLocationManager);
    }

    @Override
    public void onActivityCreated(Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);
        Log.i(TAG, "fragment onActivityCreated ----------->");
    }

    /**
     * 与OnPause()方法同时出现；
     * 此方法执行的频率更高，故其中的代码较少；
     * OnStrat():Activity由不可见变为可见的时候调用
     * 与用户进行交互的时候调用
     */
    @Override
    public void onResume() {
        super.onResume();
        mapView.onResume();
        Log.i(TAG, "fragment onResume: Running");
    }

    /**
     * 系统准备启动或恢复另一个Activity的时候调用；
     * 在此方法中通常用来释放消耗CPU的资源，以及保存一些关键数据；
     * 耗时不能过多；页面仍旧可见。
     */
    @Override
    public void onPause() {
        super.onPause();
    }
    @Override
    public void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        mapView.onSaveInstanceState(outState);
    }

    /**
     * 销毁当前Activity
     */
    @Override
    public void onDestroy() {
        super.onDestroy();
        if (((ViewPager) ((AMapActivity) getActivity()).findViewById(R.id.viewpager)).getVisibility() != View.VISIBLE) {
            Log.i(TAG, "fragment onDestroy: running");
        }
    }

}
