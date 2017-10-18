package com.example.admit.amaptest.Mine;

import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.RelativeLayout;

import com.example.admit.amaptest.R;


public class MineActivity extends AppCompatActivity implements View.OnClickListener {
    private RelativeLayout setup;
    private Button shezhi;
    private RelativeLayout back;
    private RelativeLayout toindex;
    private Button sug;
    private Button gonggao;
    private Button about_us;
    private RelativeLayout toroute;
    private int txfs = 0;
    private boolean is = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_mine);
        init();
        read();
    }
    private void read() {
        //同样，在读取SharedPreferences数据前要实例化出一个SharedPreferences对象
        SharedPreferences sharedPreferences= getSharedPreferences("setup",
                Activity.MODE_PRIVATE);
        // 使用getString方法获得value，注意第2个参数是value的默认值

        txfs = sharedPreferences.getInt("txfs",1);
        if(txfs==3)
        {
            is = true;
            shezhi.setBackgroundResource(R.mipmap.tx);
        } else {
            is = false;
            shezhi.setBackgroundResource(R.mipmap.on);
        }
    }
    private void init() {


        setup = (RelativeLayout) findViewById(R.id.setup);
        setup.setOnClickListener(this);
        back = (RelativeLayout) findViewById(R.id.back);
        back.setOnClickListener(this);
        sug = (Button) findViewById(R.id.sug);
        sug.setOnClickListener(this);
        gonggao = (Button) findViewById(R.id.gonggao);
        gonggao.setOnClickListener(this);
        about_us= (Button) findViewById(R.id.about_us);
        about_us.setOnClickListener(this);
        shezhi = (Button) findViewById(R.id.shezhi);
        shezhi.setOnClickListener(this);
    }
    private void save(){
        //实例化SharedPreferences对象（第一步）
        SharedPreferences mySharedPreferences= getSharedPreferences("setup",
                Activity.MODE_PRIVATE);
        //实例化SharedPreferences.Editor对象（第二步）
        SharedPreferences.Editor editor = mySharedPreferences.edit();
        //用putString的方法保存数据
        if(!is){
            txfs = 2;
        }
        else {
            txfs = 3;
        }
        editor.putInt("txfs", txfs);
        //提交当前数据
        editor.commit();

    }
    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.shezhi:
            case R.id.setup:
                if (is)
                {
                    is = false;
                    save();
                    shezhi.setBackgroundResource(R.mipmap.on);
                    Intent intentToSetup = new Intent(this, SetupActivity.class);
                    startActivity(intentToSetup);
                }
                else
                {
                    is = true;
                    save();
                    shezhi.setBackgroundResource(R.mipmap.tx);
                }
                break;
            case R.id.gonggao:
                Intent intentTogonggao = new Intent(this, GetShowNoticeActivity.class);
                startActivity(intentTogonggao);
                break;
            case R.id.sug:
                Intent intentTosug = new Intent(this, GetAddActivity.class);
                startActivity(intentTosug);
                break;
            case R.id.back:
                finish();
                break;
            case R.id.about_us:
                Intent intentTous = new Intent(this, AboutUsActivity.class);
                startActivity(intentTous);
                break;
            default:break;
        }

    }
    /*protected void dialog() {
        AlertDialog.Builder builder = new AlertDialog.Builder(MineActivity.this);
        builder.setMessage("确认退出吗？");
        builder.setIcon(ic_launcher);
        builder.setTitle("提示");

        builder.setPositiveButton("确认", new DialogInterface.OnClickListener() {

            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();

                MineActivity.this.finish();
            }
        }
        builder.setNegativeButton("取消", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });
        builder.create().show();
    }*/

}
