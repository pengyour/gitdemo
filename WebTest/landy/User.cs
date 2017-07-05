/**
* 命名空间: WebTest.landy
*
* 功 能： N/A
* 类 名： User
* 创建时间：2017/7/5 9:53:46
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 9:53:46 LANDY 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：厦门卫生检疫技术研究所 　　　　　　　　　　　　　　       │
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebTest.landy
{
    public class User
    {
        private String userName;

        public User(String userName)
        {
            this.userName = userName;
        }
        public String getUserName() {
            return this.userName;
        }
    }
}