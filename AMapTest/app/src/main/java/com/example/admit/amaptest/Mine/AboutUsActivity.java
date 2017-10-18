package com.example.admit.amaptest.Mine;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.Window;
import android.widget.RelativeLayout;

import com.example.admit.amaptest.R;


/**
 * Created by LMH on 2017/4/24.
 */

public class AboutUsActivity extends AppCompatActivity {
private RelativeLayout fanhui;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_aboutus);
        fanhui= (RelativeLayout) findViewById(R.id.fanhui);
        fanhui.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
    }
}
