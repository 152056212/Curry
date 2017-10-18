package com.example.admit.amaptest.index;

import android.support.v4.view.PagerAdapter;
import android.view.View;
import android.view.ViewGroup;

import java.util.List;

/**
 * Created by admit on 2017/8/18.
 */

public class MyViewPagerAdapter extends PagerAdapter {
    private List<View> views;

    public MyViewPagerAdapter(List<View> view) {
        super();
        this.views=view;
    }

    /**
     * 获取页面的数量
     */
    @Override
    public int getCount() {
        return views.size();
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
        View view = views.get(position);
        ViewGroup parent = (ViewGroup) view.getParent();
        if (parent != null)
            parent.removeAllViews();
        container.addView(view);
        return view;
    }

    @Override
    public void destroyItem(ViewGroup container, int position, Object object) {
        container.removeView(views.get(position));
    }
}
