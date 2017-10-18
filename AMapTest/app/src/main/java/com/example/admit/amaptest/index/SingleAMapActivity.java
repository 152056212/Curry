package com.example.admit.amaptest.index;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentTransaction;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Window;

import com.example.admit.amaptest.R;

/**
 * Created by admit on 2017/7/26.
 */

public abstract class SingleAMapActivity extends AppCompatActivity {
    public static final String TAG="TAG";
    protected Fragment fragment;
    protected FragmentManager fragmentManager;
    protected FragmentTransaction fragmentTransaction;
    protected abstract AMapFragment createFragment();
    @Override
    protected void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_index);
        fragmentManager=getSupportFragmentManager();
        fragmentTransaction=fragmentManager.beginTransaction();
        fragment=fragmentManager.findFragmentById(R.id.fragmentcontainer_amap);
        if(fragment==null){
            Log.i(TAG, "SingleClass-----> onCreate: fragment is null. Createing------->");
            fragment=createFragment();
            //fragmentTransaction.addToBackStack(null);
            fragmentTransaction.add(R.id.fragmentcontainer_amap,fragment,"AMapFragment").commit();
        }
    }


}
