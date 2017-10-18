package com.example.admit.amaptest.MySchedule;

import android.content.Context;
import android.content.Intent;
import android.text.TextWatcher;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.example.admit.amaptest.MyUtil.ViewGroupAnimator;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;
import com.example.admit.amaptest.index.AMapActivity;

public class StartToEndViewGroup extends LinearLayout implements View.OnClickListener {
    private RelativeLayout relativeLayout;
    private ImageView close;
    private int flagTextViewId=R.id.tv_input_end;
    private TextView inputStart;
    public static final int tv_id_inputStart=R.id.tv_input_start;
    private TextView startLatpoint;
    private RelativeLayout centerRelativeLayout;
    private ImageView reverseStartAndEnd;
    private TextView inputEnd;
    public static final int tv_id_inputEnd=R.id.tv_input_end;
    private float height=0;
    private TextView endLatpoint;
    private String cityName;

    public StartToEndViewGroup(Context context, AttributeSet attrs) {
        super(context, attrs);
        View view = LayoutInflater.from(context).inflate(R.layout.viewgroup_input, this);
        close = (ImageView) view.findViewById(R.id.img_close);
        relativeLayout=(RelativeLayout)view.findViewById(R.id.img_container);
        inputStart = (TextView) view.findViewById(R.id.tv_input_start);
        startLatpoint=(TextView)view.findViewById(R.id.tv_start_latpoint);
        centerRelativeLayout=(RelativeLayout) view.findViewById(R.id.center_relative_container);
        reverseStartAndEnd = (ImageView) view.findViewById(R.id.img_reverse_direction);
        inputEnd = (TextView) view.findViewById(R.id.tv_input_end);
        endLatpoint=(TextView)view.findViewById(R.id.tv_end_latpoint);

        height=(relativeLayout.getLayoutParams().height+inputStart.getLayoutParams().height+centerRelativeLayout.getLayoutParams().height*2+inputEnd.getLayoutParams().height)*2.5f;

        close.setOnClickListener(this);
        relativeLayout.setOnClickListener(this);
        inputStart.setOnClickListener(this);
        reverseStartAndEnd.setOnClickListener(this);
        inputEnd.setOnClickListener(this);
    }

    public int getFlagTextViewId() { return flagTextViewId; }

    public void setFlagTextViewId(int flagTextViewId) {this.flagTextViewId = flagTextViewId;}

    public TextView getStartLatpoint() {return startLatpoint;}

    public void setStartLatpoint(TextView startLatpoint) {this.startLatpoint = startLatpoint;}

    public TextView getEndLatpoint() {return endLatpoint;}

    public void setEndLatpoint(TextView endLatpoint) {this.endLatpoint = endLatpoint;}

    public float getLastHeight() { return this.height; }

    public void getMyCityName(String cityName) {
        this.cityName = cityName;
    }

    public TextView getInputStart() {
        return inputStart;
    }

    public void setInputStart(TextView inputStart) {
        this.inputStart = inputStart;
    }

    public TextView getInputEnd() {
        return inputEnd;
    }

    public void setInputEnd(TextView inputEnd) {
        this.inputEnd = inputEnd;
    }

    public TextView getTextView(int id){
        if(id==R.id.tv_input_start){
            return this.getInputStart();
        }else{
            if(id==R.id.tv_input_end)
                return this.getInputEnd();
            else
                return null;
        }
    }
    public void setTextView(int tvId,String string,String latpoint){
        if(tvId==R.id.tv_input_start){
            inputStart.setText(string);
            startLatpoint.setText(latpoint);
        }else if(tvId==R.id.tv_input_end){
            inputEnd.setText(string);
            endLatpoint.setText(latpoint);
        }
    }
    @Override
    public void onClick(View v) {
        if (v.getId() == R.id.img_close || v.getId()==R.id.img_container) {
            ViewGroupAnimator.setAnimator(this, 'H', this.getHeight(), 0);
        }
        if (v.getId() == R.id.tv_input_start || v.getId() == R.id.tv_input_end) {
            if (this.cityName != null) {
                Intent intent = new Intent(this.getContext(), MyScheduleActivity.class);
                intent.putExtra("CityName", this.cityName);
                this.setFlagTextViewId(v.getId());
                ((AMapActivity) this.getContext()).startActivityForResult(intent,  'A' + 'M' + 'A');
            } else
                ToastTools.show(getContext(), "定位信息异常，请重试");
        }
        if (v.getId() == R.id.img_reverse_direction) {

        }

    }
}
