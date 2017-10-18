package com.example.admit.amaptest.MySchedule;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.admit.amaptest.R;
import com.example.admit.amaptest.search.ItemsAdapter;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by admit on 2017/8/6.
 */

public class HistoryRecyclerAdapter extends RecyclerView.Adapter<HistoryRecyclerAdapter.ViewHolder> {

    private List<HistoryItems> historyItemses=new ArrayList<>();

    static class ViewHolder extends RecyclerView.ViewHolder {

        ImageView imgPoi;
        TextView tipsItem;
        ImageView btnDelete;

        public ViewHolder(View itemView) {
            super(itemView);
            imgPoi = (ImageView) itemView.findViewById(R.id.maker_image);
            tipsItem = (TextView) itemView.findViewById(R.id.poi_name);
            btnDelete = (ImageView) itemView.findViewById(R.id.btn_delete_history);
        }
    }

    public HistoryRecyclerAdapter(List<HistoryItems> historyItemses) {
        this.historyItemses=historyItemses;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view= LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_start_end_loaction,parent,false);
        HistoryRecyclerAdapter.ViewHolder viewHolder=new ViewHolder(view);
        return viewHolder;
    }

    @Override
    public void onBindViewHolder(HistoryRecyclerAdapter.ViewHolder holder, int position) {
        HistoryItems historyItem=historyItemses.get(position);
        holder.imgPoi.setImageResource(historyItem.getImgId());
        holder.tipsItem.setText(historyItem.getIntro());
        holder.btnDelete.setImageResource(historyItem.getImgId());
    }

    @Override
    public long getItemId(int position) {
        return super.getItemId(position);
    }

    @Override
    public int getItemCount() {
        return historyItemses.size();
    }
}
