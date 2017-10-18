package com.example.admit.amaptest.index;

import android.content.Context;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v4.view.PagerAdapter;
import android.support.v4.view.ViewPager;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.admit.amaptest.R;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by admit on 2017/7/29.
 */

public class ViewpagerFragment extends Fragment {
    private static final String TAG = "TAG";

    private ViewPager viewPager;
    private List<View> viewContainer = new ArrayList<>();
    private ViewpagerManageable viewpagerManageable;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_viewpager, container);
        viewPager = (ViewPager) view.findViewById(R.id.viewpager);

        for (int i = 0; i < 10; i++)
            viewContainer.add(new BusLineItemViewpager(getActivity()));
        viewPager.setAdapter(new MyPagerAdapter());

        return view;
    }

    public class MyPagerAdapter extends PagerAdapter {

        public MyPagerAdapter() {
            super();
        }

        /**
         * 获取页面的数量
         */
        @Override
        public int getCount() {
            return viewContainer.size();
        }

        /**
         * 判断某个子view是否和object关联
         */
        @Override
        public boolean isViewFromObject(View view, Object object) {
            return view == object;
        }

        /**
         * 添加一个页面返回关联这个页面的object
         */
        @Override
        public Object instantiateItem(ViewGroup container, int position) {
            View view = viewContainer.get(position);
            ViewGroup parent = (ViewGroup) view.getParent();
            if (parent != null)
                parent.removeAllViews();
            container.addView(view);
            return view;
        }

        @Override
        public void destroyItem(ViewGroup container, int position, Object object) {
            container.removeView(viewContainer.get(position));
        }
    }

    public void returnViewpager(ViewpagerManageable viewpagerManageable) {
        Log.i(TAG, "returnViewpager-----------> 初始化viewpager 中");
        this.viewpagerManageable = viewpagerManageable;
    }

    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
    }

    @Override
    public void onResume() {
        super.onResume();
    }

    @Override
    public void onDestroy() {
        super.onDestroy();
    }

    @Override
    public void onPause() {
        super.onPause();
    }

    @Override
    public void onStop() {
        super.onStop();
    }

    @Override
    public void onDetach() {
        super.onDetach();
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();

    }
}
