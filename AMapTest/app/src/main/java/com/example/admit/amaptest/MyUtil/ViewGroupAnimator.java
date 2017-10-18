package com.example.admit.amaptest.MyUtil;

import android.animation.ValueAnimator;
import android.view.View;

/**
 * Created by admit on 2017/8/5.
 */

public class ViewGroupAnimator {
    public static void setAnimator(View view, int type, float startValue, float endValue) {
        //设置动画初始值&结束值
        final View viewTemp = view;
        final int heightOrWidth = type;
        ValueAnimator animator = ValueAnimator.ofFloat(startValue, endValue);
        animator.setDuration(350);
        animator.setStartDelay(500);
        animator.setRepeatCount(0);
        animator.setRepeatMode(ValueAnimator.RESTART);
        //将设置的值赋值给对象的属性值
        animator.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() {

            @Override
            public void onAnimationUpdate(ValueAnimator animation) {
                //获取改变的值
                float currentValue = (Float) animation.getAnimatedValue();
                //设置对象的属性值
                if (heightOrWidth == 'H')
                    viewTemp.getLayoutParams().height = (int)currentValue;
                else
                    viewTemp.getLayoutParams().width = (int)currentValue;
                //刷新对象的状态
                viewTemp.requestLayout();
            }
        });
        animator.start();
    }
}
