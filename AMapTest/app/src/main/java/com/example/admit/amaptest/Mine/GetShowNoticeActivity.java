package com.example.admit.amaptest.Mine;

import android.net.Uri;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.util.Xml;
import android.view.View;
import android.view.Window;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.example.admit.amaptest.R;
import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.appindexing.Thing;
import com.google.android.gms.common.api.GoogleApiClient;

import org.json.JSONArray;
import org.xmlpull.v1.XmlPullParser;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;


/**
 * Created by LMH on 2017/4/22.
 */

public class GetShowNoticeActivity extends AppCompatActivity implements View.OnClickListener {

    private byte[] s = null;
    private static String m;
    private static String[] xmllist;
    private static String[] notice;
    private static String[] notice2;
    private static String mes = "";
    private static String mes1 = "";
    private static String mes2 = "";
    private static String mes3 = "";
    private static String mes4 = "";

    private static String Ttitle0;
    private static String Ttitle1;
    private static String Ttitle2;
    private static String Ttitle3;
    private static String Ttitle4;
    private static  int i;
    private LinearLayout gonggao1;
    private LinearLayout gonggao2;
    private LinearLayout gonggao3;
    private LinearLayout gonggao4;
    private RelativeLayout fanhui;
    private ImageView img1;
    private ImageView img2;
    private ImageView img3;
    private ImageView img4;
    private TextView message;
    private TextView message1;
    private TextView message2;
    private TextView message3;
    private TextView message4;
    private TextView title0;
    private TextView title1;
    private TextView title2;
    private TextView title3;
    private TextView title4;
    private ImageView img0;
    private LinearLayout gonggao0;
    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */
    private GoogleApiClient client;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_notice);
        fanhui = (RelativeLayout) findViewById(R.id.fanhui);
        fanhui.setOnClickListener(this);
        title0 = (TextView) findViewById(R.id.title0);
        title1 = (TextView) findViewById(R.id.title1);
        title2 = (TextView) findViewById(R.id.title2);
        title3 = (TextView) findViewById(R.id.title3);
        title4 = (TextView) findViewById(R.id.title4);
        img0 = (ImageView) findViewById(R.id.img0);
        img1 = (ImageView) findViewById(R.id.img1);
        img2 = (ImageView) findViewById(R.id.img2);
        img3 = (ImageView) findViewById(R.id.img3);
        img4 = (ImageView) findViewById(R.id.img4);
        message = (TextView) findViewById(R.id.message);
        message1 = (TextView) findViewById(R.id.message1);
        message2 = (TextView) findViewById(R.id.message2);
        message3 = (TextView) findViewById(R.id.message3);
        message4 = (TextView) findViewById(R.id.message4);
        gonggao0 = (LinearLayout) findViewById(R.id.gonggao0);
        gonggao1 = (LinearLayout) findViewById(R.id.gonggao1);
        gonggao2 = (LinearLayout) findViewById(R.id.gonggao2);
        gonggao3 = (LinearLayout) findViewById(R.id.gonggao3);
        gonggao4= (LinearLayout) findViewById(R.id.gonggao4);
        // 启动一个新线程的代码：
        new Thread() {
            @Override
            public void run() {
                try {
                    s = requestBYGet();
                    runOnUiThread(new Runnable() {
                        @Override
                        public void run() {


                                message.setText(mes);
                                title0.setText(Ttitle0);
                                img0.setImageResource(R.drawable.notice);
                                gonggao0.setBackgroundColor(getResources().getColor(R.color.colorWhite));

                            if (i>1) {
                                message1.setText(mes1);
                                title1.setText(Ttitle1);
                                img1.setImageResource(R.drawable.notice);
                                gonggao1.setBackgroundColor(getResources().getColor(R.color.colorWhite));
                            }
                            if (i>2) {
                                message2.setText(mes2);
                                title2.setText(Ttitle2);
                                img2.setImageResource(R.drawable.notice);
                                gonggao2.setBackgroundColor(getResources().getColor(R.color.colorWhite));
                            }
                            if (i>3) {
                                message3.setText(mes3);
                                title3.setText(Ttitle3);
                                img3.setImageResource(R.drawable.notice);
                                gonggao3.setBackgroundColor(getResources().getColor(R.color.colorWhite));
                            }
                            if (i>4) {
                                message4.setText(mes4);
                                title4.setText(Ttitle4);
                                img4.setImageResource(R.drawable.notice);
                                gonggao4.setBackgroundColor(getResources().getColor(R.color.colorWhite));
                            }

                        }
                    });
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }.start();


        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        client = new GoogleApiClient.Builder(this).addApi(AppIndex.API).build();
    }

    // Get方式请求
    public static byte[] requestBYGet() throws Exception {
        String path = "http://xdssgj.cn/gbook/notice.asmx/showNotice";
        byte[] data = null;
        // 新建一个URL对象
        URL url = new URL(path);
        // 打开一个HttpURLConnection连接
        HttpURLConnection urlConn = (HttpURLConnection) url.openConnection();
        // 设置连接超时时间
        urlConn.setConnectTimeout(5000);
        //开始连接
        urlConn.connect();
        //判断请求是否成功
        if (urlConn.getResponseCode() == 200) {
            //获取返回数据


            //简析xml
            XmlPullParser parser = Xml.newPullParser(); //由android.util.Xml创建一个XmlPullParser实例
            parser.setInput(urlConn.getInputStream(), "UTF-8");               //设置输入流 并指明编码方式

            int eventType = parser.getEventType();
            while (eventType != XmlPullParser.END_DOCUMENT) {
                switch (eventType) {
                    case XmlPullParser.START_TAG:
                        if (parser.getName().equals("string")) {
                            eventType = parser.next();
                            //简析json
                            JSONArray jsonArray = new JSONArray(parser.getText());
                            if (jsonArray.length() > 0) {

                                        i = jsonArray.length();
                                        mes = jsonArray.getJSONObject(0).getString("nContent");
                                        Ttitle0 = jsonArray.getJSONObject(0).getString("nTitle");

                                    if (jsonArray.length()>1)
                                    {
                                        mes1 = jsonArray.getJSONObject(1).getString("nContent");
                                        Ttitle1 = jsonArray.getJSONObject(1).getString("nTitle");
                                    }
                                    if (jsonArray.length()>2)
                                    {
                                        mes2 = jsonArray.getJSONObject(2).getString("nContent");
                                        Ttitle2 = jsonArray.getJSONObject(2).getString("nTitle");
                                    }

                                    if (jsonArray.length()>3)
                                    {
                                        mes3 = jsonArray.getJSONObject(3).getString("nContent");
                                        Ttitle3 = jsonArray.getJSONObject(3).getString("nTitle");
                                    }
                                    if (jsonArray.length()>4)
                                    {
                                        mes4 = jsonArray.getJSONObject(4).getString("nContent");
                                        Ttitle4 = jsonArray.getJSONObject(4).getString("nTitle");
                                    }



                            }
                        }
                        break;
                    case XmlPullParser.END_TAG:

                        break;
                }
                eventType = parser.next();
            }
        } else {
            Log.i("haha", "Get方式请求失败");
        }
        // 关闭连接
        urlConn.disconnect();
        return data;

    }

    // 获取连接返回的数据
    private static byte[] readStream(InputStream inputStream) throws Exception {
        byte[] buffer = new byte[1024];
        int len = -1;
        ByteArrayOutputStream baos = new ByteArrayOutputStream();
        while ((len = inputStream.read(buffer)) != -1) {
            baos.write(buffer, 0, len);
        }
        byte[] data = baos.toByteArray();
        inputStream.close();
        baos.close();
        return data;
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.fanhui:
                finish();
                break;
        }

    }

    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */
    public Action getIndexApiAction() {
        Thing object = new Thing.Builder()
                .setName("GetShowNoticeActivity Page") // TODO: Define a title for the content shown.
                // TODO: Make sure this auto-generated URL is correct.
                .setUrl(Uri.parse("http://[ENTER-YOUR-URL-HERE]"))
                .build();
        return new Action.Builder(Action.TYPE_VIEW)
                .setObject(object)
                .setActionStatus(Action.STATUS_TYPE_COMPLETED)
                .build();
    }

    @Override
    public void onStart() {
        super.onStart();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        client.connect();
        AppIndex.AppIndexApi.start(client, getIndexApiAction());
    }

    @Override
    public void onStop() {
        super.onStop();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        AppIndex.AppIndexApi.end(client, getIndexApiAction());
        client.disconnect();
    }
}
