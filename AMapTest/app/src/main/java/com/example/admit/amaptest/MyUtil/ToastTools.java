package com.example.admit.amaptest.MyUtil;

import android.content.Context;
import android.widget.Toast;

/**
 * Created by admit on 2017/7/21.
 */

public final  class ToastTools {
    public final static void show(Context context,String string){
        Toast.makeText(context,string,Toast.LENGTH_SHORT).show();
    }
    public static void show(Context context, int info) {
        Toast.makeText(context, info, Toast.LENGTH_LONG).show();
    }
}
