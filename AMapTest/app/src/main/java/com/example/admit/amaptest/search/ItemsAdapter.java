package com.example.admit.amaptest.search;

import android.content.Context;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.admit.amaptest.R;
import com.example.admit.amaptest.index.AMapActivity;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.List;

/**
 * Created by admit on 2017/7/31.
 */

public class ItemsAdapter extends RecyclerView.Adapter<ItemsAdapter.ViewHolder> {

    private List<SearchTips> mTips;
    private MyItemOnclickListener myItemOnclickListener;

    public ItemsAdapter() {
        super();
    }

    static class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener{
        ImageView imgPoi;
        TextView tipsItem;
        private List<SearchTips> mTips;
        private MyItemOnclickListener myItemOnclickListener;
        public ViewHolder(MyItemOnclickListener myItemOnclickListener,View itemView,List<SearchTips> mTips) {
            super(itemView);
            this.myItemOnclickListener=myItemOnclickListener;
            this.mTips=mTips;
            imgPoi=(ImageView) itemView.findViewById(R.id.maker_image);
            tipsItem=(TextView)itemView.findViewById(R.id.poi_name);
            tipsItem.setOnClickListener(this);
        }
        @Override
        public void onClick(View v) {
           myItemOnclickListener.itemOnclick(v,this.mTips.get(getAdapterPosition()));
        }
    }
    public ItemsAdapter(MyItemOnclickListener myItemOnclickListener,List<SearchTips> mTips){
        this.myItemOnclickListener=myItemOnclickListener;
        this.mTips=mTips;
    }

    /**
     * 加载item布局
     * 创建viewholder的实例
     * 把加载出来的实例返回到构造函数中，返回viewholder的实例
     */
    @Override
    public ItemsAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view= LayoutInflater.from(parent.getContext()).inflate(R.layout.recyclerview_tips_item,parent,false);
        final ItemsAdapter.ViewHolder holder=new ItemsAdapter.ViewHolder(myItemOnclickListener,view,this.mTips);
        return holder;
    }

    /**
     * 对Recycler子项的数据进行赋值，
     */
    @Override
    public void onBindViewHolder(ItemsAdapter.ViewHolder holder, int position) {
        SearchTips searchTips =mTips.get(position);
        holder.imgPoi.setImageResource(searchTips.getImgId());
        holder.tipsItem.setText(searchTips.getIntro().getName());
        holder.tipsItem.setTextSize(16);
    }

    @Override
    public int getItemCount() {
        return mTips.size();
    }
}
