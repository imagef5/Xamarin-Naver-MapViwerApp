﻿/*
 * 소스 참조 : https://developers.naver.com/docs/map/android/
 *           https://github.com/navermaps/maps.android
 * 네이버 지도에 서비스 저작권에 대한 자세한 내용은 Naver Developer 페이지를 참조하시기 바랍니다.
 * (https://github.com/navermaps/maps.android#license)
 * 
 * Copyright 2016 NAVER Corp.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using Android.App;
using Android.Runtime;

namespace NaverMapViewAndroidApp.Samples
{
    [Application(Name = "naver.map.NMapViewerApplication")]
    public class NMapViewerApplication : Application
    {
        public NMapViewerApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
        #region private member fileds area
        static NMapViewerApplication instance;
        #endregion

        #region Property Area
        public static NMapViewerApplication Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        #region override methods area
        public override void OnCreate()
        {

            base.OnCreate();

            instance = this;
        }
        #endregion
    }
}
