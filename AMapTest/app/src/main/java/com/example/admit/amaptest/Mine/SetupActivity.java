package com.example.admit.amaptest.Mine;

import android.app.Activity;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.RelativeLayout;
import android.widget.Spinner;

import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;


public class SetupActivity extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemSelectedListener {

    private RelativeLayout back;
    private Spinner notifyMethod;
    private ArrayAdapter<CharSequence> AdapterXml;
    private Spinner stepNotify;
    private Spinner refreshFrequency;
    private Button btnSave;

    private int txfs = 0;
    private int dztx = 0;
    private int sxpl = 0;
    private boolean first = true;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_setup);
        init();
        read();
    }

    private void init() {
        back = (RelativeLayout) findViewById(R.id.back);
        back.setOnClickListener(this);
        btnSave = (Button) findViewById(R.id.btn_save);
        btnSave.setOnClickListener(this);
        notifyMethod = (Spinner) findViewById(R.id.spinner_notifyMethod);
        stepNotify = (Spinner) findViewById(R.id.spinner_stepNotify);
        refreshFrequency = (Spinner) findViewById(R.id.spinner_refreshFrequency);

        initSpinnerByXml(notifyMethod,R.array.notifyMethod);
        initSpinnerByXml(stepNotify,R.array.stepNotify);
        initSpinnerByXml(refreshFrequency,R.array.refreshFrequency);

        notifyMethod.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                //拿到被选择项的值
                String s = (String) notifyMethod.getSelectedItem();
                if (s.contains("震动")) {
                    txfs = 0;
                }
                if (s.contains("响铃")) {
                    txfs = 1;
                }
                if (s.contains("响铃加震动")) {
                    txfs = 2;
                }
                if (s.contains("不提醒")) {
                    txfs = 3;
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });
        stepNotify.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                //拿到被选择项的值
                String s = (String) stepNotify.getSelectedItem();
                if (s.contains("三站提醒")) {
                    dztx = 0;
                }
                if (s.contains("二站提醒")) {
                    dztx = 1;
                }
                if (s.contains("一站提醒")) {
                    dztx = 2;
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });
        refreshFrequency.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                //拿到被选择项的值
                String s = (String) refreshFrequency.getSelectedItem();
                if (s.contains("快")) {
                    sxpl = 0;
                }
                if (s.contains("中等")) {
                    sxpl = 1;
                }
                if (s.contains("慢")) {
                    sxpl = 2;
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });
    }
    private void initSpinnerByXml(Spinner spainner,int arrayId){
        AdapterXml=ArrayAdapter.createFromResource(this,arrayId,R.layout.support_simple_spinner_dropdown_item);
        spainner.setAdapter(AdapterXml);
    }
    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.back:
                finish();
                break;
            case R.id.btn_save:
                save();
                break;
            default:
                break;
        }
    }

    private void save() {
        //实例化SharedPreferences对象（第一步）
        SharedPreferences mySharedPreferences = getSharedPreferences("setup",
                Activity.MODE_PRIVATE);
        //实例化SharedPreferences.Editor对象（第二步）
        SharedPreferences.Editor editor = mySharedPreferences.edit();
        //用putString的方法保存数据
        editor.putInt("txfs", txfs);
        editor.putInt("dztx", dztx);
        editor.putInt("sxpl", sxpl);
        //提交当前数据
        editor.commit();
        ToastTools.show(getApplication(), "\n" + "保存成功" + "\n");
    }

    private void read() {
        //同样，在读取SharedPreferences数据前要实例化出一个SharedPreferences对象
        SharedPreferences sharedPreferences = getSharedPreferences("setup",
                Activity.MODE_PRIVATE);
        // 使用getString方法获得value，注意第2个参数是value的默认值
        int name1 = sharedPreferences.getInt("txfs", 1);
        int name2 = sharedPreferences.getInt("dztx", 1);
        int name3 = sharedPreferences.getInt("sxpl", 1);
        txfs = name1;
        dztx = name2;
        sxpl = name3;

    }

    @Override
    public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {

    }
    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }
}
