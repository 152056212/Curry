package com.example.admit.amaptest.MyUtil;

import android.view.KeyEvent;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.AutoCompleteTextView;
import android.widget.TextView;

import static com.example.admit.amaptest.R.styleable.View;

/**
 * Created by admit on 2017/8/7.
 */

public class AutoCompleteTextviewKeyListener {
    public static void setKey(AutoCompleteTextView autoCompleteTextView){
       autoCompleteTextView.setOnEditorActionListener(new TextView.OnEditorActionListener() {
           @Override
           public boolean onEditorAction(TextView v, int actionId, KeyEvent event) {
               return false;
           }
       });
    }
}
