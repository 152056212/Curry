package com.example.admit.amaptest.MySchedule;

/**
 * Created by admit on 2017/8/6.
 */

public class HistoryItems {



    private int iconId;
    private String  intro;
    private int  imgId;

    public HistoryItems(int  iconId, String  intro,int  imgId) {
        this.iconId=iconId;
        this.intro = intro;
        this.imgId = imgId;
    }

    public int getIconId() {return iconId;}
    public void setIconId(int iconId) {this.iconId = iconId;}
    public int getImgId() {
        return imgId;
    }
    public void setImgId(int imgId) {
        this.imgId = imgId;
    }
    public String getIntro() {
        return intro;
    }
    public void setIntro(String intro) {
        this.intro = intro;
    }
}
