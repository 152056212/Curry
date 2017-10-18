package com.example.admit.amaptest.busStaionIntro;


import android.os.Parcel;
import android.os.Parcelable;

import com.amap.api.services.busline.BusLineItem;

import java.util.ArrayList;
import java.util.List;

public class BusLineItemInfro implements Parcelable{

    private List<BusLineItem> busLineItems;

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
       dest.writeList(busLineItems);
    }
    public BusLineItemInfro() { }
    public BusLineItemInfro(List<BusLineItem> busLineItems){
        this.busLineItems=busLineItems;
    }
    protected BusLineItemInfro(Parcel parcel){
        busLineItems=new  ArrayList<BusLineItem>();
        parcel.readList(busLineItems,getClass().getClassLoader());
    }
    public static final Parcelable.Creator<BusLineItemInfro> CREATOR=new Parcelable.Creator<BusLineItemInfro>(){
        @Override
        public BusLineItemInfro createFromParcel(Parcel source) {
            return new BusLineItemInfro(source);
        }

        @Override
        public BusLineItemInfro[] newArray(int size) {
            return new BusLineItemInfro[size];
        }
    };

    public List<BusLineItem> getBusLineItems() {
        return busLineItems;
    }

    public void setBusLineItems(ArrayList<BusLineItem> busLineItems) {
        this.busLineItems = busLineItems;
    }
}
