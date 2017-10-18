package com.example.admit.amaptest.MyUtil;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;



public class NetworkUtil {
    public static boolean isConnected(Context context){
        ConnectivityManager connectivityManager=(ConnectivityManager) context.getApplicationContext().getSystemService(Context.CONNECTIVITY_SERVICE);
        NetworkInfo info=connectivityManager.getActiveNetworkInfo();
        return info != null && info.isConnected();
    }
}
