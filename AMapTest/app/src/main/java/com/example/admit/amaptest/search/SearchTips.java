package com.example.admit.amaptest.search;

import android.widget.ImageView;
import android.widget.TextView;

import com.amap.api.services.help.Tip;

/**
 * Created by admit on 2017/7/31.
 */

public class SearchTips {

    private int  imgId;
    private String infor;
    private Tip intro;

    public SearchTips(int  imgId, Tip  intro) {
        this.imgId = imgId;
        this.intro = intro;
    }

    public  SearchTips(int imgId, String infor){
        this.imgId=imgId;
        this.infor=infor;

    }

    public String getInfor() {return infor;}

    public void setInfor(String infor) {this.infor = infor;}

    public int getImgId() {
        return imgId;
    }

    public void setImgId(int imgId) {
        this.imgId = imgId;
    }

    public Tip getIntro() {
        return intro;
    }

    public void setIntro(Tip intro) {
        this.intro = intro;
    }
}
