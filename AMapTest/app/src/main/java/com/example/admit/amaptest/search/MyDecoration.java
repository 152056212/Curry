package com.example.admit.amaptest.search;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Canvas;
import android.graphics.Rect;
import android.graphics.drawable.Drawable;
import android.support.v7.widget.DrawableUtils;
import android.support.v7.widget.LinearLayoutCompat;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.View;

/**
 * Created by admit on 2017/8/1.
 */

public class MyDecoration extends RecyclerView.ItemDecoration {

    private Context context;
    private Drawable drawable;
    private int orientation;
    public static final int HORIZONTAL_LIST= LinearLayoutManager.HORIZONTAL;
    public static final int VERTICAL_LIST=LinearLayoutManager.VERTICAL;

    /**
     * 获取系统属性中的listdivider
     */
    public static final int[] ATRRS = new int[]{
            android.R.attr.listDivider
    };

    public MyDecoration(Context context, int orientation) {
        Log.i("TAG", "MyDecoration--------------------------------------->  初始化中");
        this.context = context;
        final TypedArray ta = context.obtainStyledAttributes(ATRRS);
        this.drawable=ta.getDrawable(0);
        ta.recycle();
        setOritention(orientation);

    }

    /**
     * 获取屏幕的方向
     */
    public void setOritention(int oritention){
     this.orientation=oritention;
    }

    @Override
    public void onDraw(Canvas c, RecyclerView parent, RecyclerView.State state) {
        if(orientation==HORIZONTAL_LIST){
            drawVerticalLine(c,parent,state);
        }else{
            drawaHorizontalLine(c,parent,state);
        }
    }

    public void drawaHorizontalLine(Canvas c,RecyclerView parent,RecyclerView.State state){

        int left=parent.getPaddingLeft();
        int right=parent.getWidth()-parent.getPaddingRight();

        final int childCount=parent.getChildCount();
        for (int i=0;i<childCount;i++){
            //获取布局信息
            final View child=parent.getChildAt(i);
            final RecyclerView.LayoutParams layoutParams=(RecyclerView.LayoutParams)child.getLayoutParams();
            final int top=child.getBottom()+layoutParams.bottomMargin;
            final int bottom=top+drawable.getIntrinsicHeight();
            drawable.setBounds(left,top,right,bottom);
            drawable.draw(c);

        }

    }
    public  void drawVerticalLine(Canvas canvas,RecyclerView parent,RecyclerView.State state){

        int top=parent.getTop();
        int bottom=parent.getHeight()-parent.getBottom();
        final int childCount = parent.getChildCount();

        for (int i=0;i<childCount;i++){
            final View child=parent.getChildAt(i);
            //同上
            final RecyclerView.LayoutParams layoutParams = (RecyclerView.LayoutParams) child.getLayoutParams();
            final int left=child.getRight()+layoutParams.rightMargin;
            final int right=left+drawable.getIntrinsicWidth();
            drawable.setBounds(left,top,right,bottom);
            drawable.draw(canvas);
        }
    }
    @Override
    public void getItemOffsets(Rect outRect, View view, RecyclerView parent, RecyclerView.State state) {
        if(orientation==HORIZONTAL_LIST){
            outRect.set(0,0,0,drawable.getIntrinsicHeight());
        }else
        outRect.set(0,0,drawable.getIntrinsicWidth(),0);

    }
}
