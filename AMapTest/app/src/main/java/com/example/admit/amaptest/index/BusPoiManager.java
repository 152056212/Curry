package com.example.admit.amaptest.index;

import android.content.Context;
import android.graphics.BitmapFactory;
import android.util.Log;
import android.widget.Toast;

import com.amap.api.maps.AMap;
import com.amap.api.maps.model.BitmapDescriptorFactory;
import com.amap.api.maps.model.LatLng;
import com.amap.api.maps.model.MarkerOptions;
import com.amap.api.maps.model.Text;
import com.amap.api.maps.model.TextOptions;
import com.amap.api.services.core.LatLonPoint;
import com.amap.api.services.core.PoiItem;
import com.amap.api.services.poisearch.PoiResult;
import com.amap.api.services.poisearch.PoiSearch;
import com.example.admit.amaptest.MyUtil.ToastTools;
import com.example.admit.amaptest.R;

import java.util.ArrayList;
import java.util.Iterator;

/**
 * Created by admit on 2017/8/2.
 */

public  class BusPoiManager implements PoiSearch.OnPoiSearchListener {
    protected static final String TAG = "TAG";
    protected final String Query_String = "公交车站";
    protected final String CTGR_BUS_POI = "150700";
    protected Context context;
    protected AMap aMap;
    protected LatLng latLng;
    protected String cityCode;
    protected PoiSearch.Query busQuery;
    protected ArrayList<PoiItem> poiList;
    protected Iterator<PoiItem> iterator;
    protected Iterator<PoiItem> iteratorTag;
    protected MarkerOptions markerOption;
    protected PoiItem subPoiItem;
    public Text text;
    public TextOptions textOptions;

    public BusPoiManager(){ }
    public BusPoiManager(Context context, AMap aMap, LatLng latLng) {
        this.context = context;
        this.aMap = aMap;
        this.latLng = latLng;
    }

    public BusPoiManager(Context context, AMap aMap, String cityCode) {
        this.context = context;
        this.aMap = aMap;
        this.cityCode = cityCode;
    }
    public BusPoiManager(Context context, AMap aMap, LatLng latLng, String cityCode) {
        this.context = context;
        this.aMap = aMap;
        this.cityCode = cityCode;
        this.setLatLng(latLng);
    }

    public PoiSearch.Query getBusQuery() {
        return busQuery;
    }
    public LatLng getLatLng() {
        return latLng;
    }
    public void setLatLng(LatLng latLng) {
        this.latLng = latLng;
    }
    public void setBusQuery(String query, String ctgr, String cityCode) {
        this.busQuery = new PoiSearch.Query(query, ctgr, cityCode);
    }

    @Override
    public void onPoiItemSearched(PoiItem poiItem, int i) { }
    public void busPoiSearchNearby() {
        /**
         * keyWord表示搜索字符串;
         * 第二个参数表示POI搜索类型，二者选填其一，选用POI搜索类型时建议填写类型代码，码表可以参考下方（而非文字）;
         * cityCode表示POI搜索区域，可以是城市编码也可以是城市名称，也可以传空字符串，空字符串代表全国在全国范围内进行搜索
         */
        this.setBusQuery(this.Query_String,this.CTGR_BUS_POI,this.cityCode);
        Log.i(TAG, "busPOISeatch: start---");
        this.getBusQuery().setPageSize(10);// 设置每页最多返回多少条poiitem
        this.getBusQuery().setPageNum(0);
        PoiSearch poiSearch = new PoiSearch(this.context, this.getBusQuery());
        if (this.getLatLng() != null) {
            Log.i(TAG, "busPOISeatch: myLatLng-->经度：" + this.getLatLng().longitude + "\n");
            poiSearch.setBound(new PoiSearch.SearchBound(new LatLonPoint(this.getLatLng().latitude, this.getLatLng().longitude), 5000));
        } else {
            Toast.makeText(this.context, "Search Error", Toast.LENGTH_SHORT).show();
        }
        poiSearch.setOnPoiSearchListener(this);
        poiSearch.searchPOIAsyn();
        Log.i(TAG, "running PoiSearch");
        Log.i(TAG, "busPOISeatch: end---");
    }
    @Override
    public void onPoiSearched(PoiResult poiResult, int i) {
        if (i == 1000 && poiResult != null) {//i==1000:SearchSucessed；
            Log.i(TAG, "onPoiSearched:搜索——-->" + "总页数： " + poiResult.getPageCount() + "\n");
            poiList = poiResult.getPois();
            iterator = poiList.iterator();
            iteratorTag = poiList.iterator();
            markerOption = new MarkerOptions();
            textOptions =new TextOptions();
            Log.i(TAG, "onPoiSearched: 查找成功: size " + poiList.size() + " counting " + busQuery.getPageNum() + "\n");
            int g = 0;
            if (poiList == null || iterator == null)
                Log.i(TAG, "onPoiSearched: 返回查询结果为空！\n");
            while (iterator.hasNext()) {
                subPoiItem = iterator.next();
                Log.i(TAG, "while:" + "第 " + g + " 个POI的中心距： " + subPoiItem.getDistance()
                        + " Title: " + subPoiItem.getTitle() + "PoiId: " + subPoiItem.getPoiId()
                        + " " + subPoiItem.toString() + " 经度：" + subPoiItem.getLatLonPoint().getLongitude()
                        + " 纬度：" + subPoiItem.getLatLonPoint().getLatitude() + "\n");
                TextOptions textOptions=new TextOptions();
                textOptions.visible(true);
                Text text = this.aMap.addText(textOptions);
                text.setPosition(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude()));
                text.setText(subPoiItem.getTitle());
                text.setVisible(true);
                markerOption.position(new LatLng(subPoiItem.getLatLonPoint().getLatitude(), subPoiItem.getLatLonPoint().getLongitude()));
                markerOption.icon(BitmapDescriptorFactory.fromBitmap(BitmapFactory.decodeResource(this.context.getResources(), R.drawable.poi_maker_bus)));
                markerOption.isVisible();
                markerOption.title(subPoiItem.getTitle());
                markerOption.isInfoWindowEnable();
                markerOption.draggable(false);//设置Marker可拖动
                markerOption.setFlat(true);//设置marker平贴地图效果
                markerOption.perspective(true);
                aMap.addMarker(markerOption);
                Log.i(TAG, "maker " + markerOption.getTitle() + "\n");
                g++;
            }
            if (!iterator.hasNext()) {
                iterator = iteratorTag;
                if (iterator.hasNext()) Log.i(TAG, "don't is NULL \n");
            }
        }
        else {
            ToastTools.show(this.context,"Search Filed");
        }
    }
}
