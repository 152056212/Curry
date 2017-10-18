package com.example.admit.amaptest.index;

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

public class BusLinesAdapter extends RecyclerView.Adapter<BusLinesAdapter.ViewHolder> {

    private List<String> mBusLineItem;

    public BusLinesAdapter() {
        super();
    }

    static class ViewHolder extends RecyclerView.ViewHolder {
        TextView busLineName;

        public ViewHolder(View itemView) {
            super(itemView);
            busLineName = (TextView) itemView.findViewById(R.id.busline_name);
        }
    }

    public BusLinesAdapter(List<String> mBusLineItem) {
        this.mBusLineItem = mBusLineItem;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_busline_item, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(ViewHolder holder, int position) {
        int flag = mBusLineItem.get(position).indexOf("(");
        if (flag != -1) {
            String busLN = mBusLineItem.get(position).substring(0, flag);
            holder.busLineName.setText(busLN);
        }
    }

    @Override
    public int getItemCount() {
        return mBusLineItem.size();
    }
}
