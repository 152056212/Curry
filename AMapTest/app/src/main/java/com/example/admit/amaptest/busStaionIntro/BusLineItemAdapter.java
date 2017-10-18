package com.example.admit.amaptest.busStaionIntro;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.admit.amaptest.R;

import java.util.List;

/**
 * Created by admit on 2017/7/29.
 */

class BusLineItemAdapter extends RecyclerView.Adapter<BusLineItemAdapter.ViewHolder> {

    private List<String> mBusLineItem;

    public BusLineItemAdapter() {
        super();
    }

    static class ViewHolder extends RecyclerView.ViewHolder {
        TextView busLineName;
        TextView busLineIntro;

        public ViewHolder(View itemView) {
            super(itemView);
            busLineName = (TextView) itemView.findViewById(R.id.tv_line_name);
            busLineIntro = (TextView) itemView.findViewById(R.id.tv_line_intro);
        }
    }

    public BusLineItemAdapter(List<String> mBusLineItem) {
        this.mBusLineItem = mBusLineItem;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_station_lines, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(ViewHolder holder, int position) {
        int lenth = mBusLineItem.get(position).length();
        int flag = mBusLineItem.get(position).indexOf("(");
        if (flag != -1) {
            String stationName = mBusLineItem.get(position).substring(0, flag);
            String stationintro = mBusLineItem.get(position).substring(flag + 1, lenth - 1);
            holder.busLineName.setText(stationName);
            holder.busLineIntro.setText(stationintro);
        }
    }

    @Override
    public int getItemCount() {
        return mBusLineItem.size();
    }
}
