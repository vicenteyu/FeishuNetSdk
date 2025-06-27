// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出记录 响应体
/// <para>接口ID：6952707657162571778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"data":{"items":[{
    "fields": {
        "索引": "索引列多行文本类型",
        "多行文本": "多行文本内容1",
        "数字": "100",
        "单选": "选项1",
        "多选": ["选项1", "选项2"],
        "日期": 1674206443000,
        "复选框": true,
        "人员": [{
            "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/b2-7619-4b8a-b27b-c72d90b06a2j~?image_size=72x72&cut_type=default-face&quality=&format=jpeg&sticker_format=.webp",
            "email": "zhangsan.leben@bytedance.com",
            "en_name": "ZhangSan",
            "id": "ou_2910013f1e6456f16a0ce75ede950a0a",
            "name": "张三"
        }, {
            "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/v2_q86-fcb6-4f18-85c7-87ca8881e50j~?image_size=72x72&cut_type=default-face&quality=&format=jpeg&sticker_format=.webp",
            "email": "lisi.00@bytedance.com",
            "en_name": "LiSi",
            "id": "ou_e04138c9633dd0d2ea166d79f548ab5d",
            "name": "李四"
        }],
        "群组": [{
            "avatar_url": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_c8d2cd50-ba29-476f-b7f1-5b5917cb18ej~?image_size=72x72&cut_type=&quality=&format=jpeg&sticker_format=.webp",
            "id": "oc_cd07f55f14d6f4a4f1b51504e7e97f48",
            "name": "武侠聊天组"
        }],
        "电话号码": "131xxxx6666",
        "超链接": {
            "link": "https://bitable.feishu.cn",
            "text": "飞书多维表格官网"
        },
        "附件": [{
            "file_token": "Vl3FbVkvnowlgpxpqsAbBrtFcrd",
            "name": "飞书.jpeg",
            "size": 32975,
            "tmp_url": "https://open.feishu.cn/open-apis/drive/v1/medias/batch_get_tmp_download_url?file_tokens=Vl3FbVk11owlgpxpqsAbBrtFcrd&extra=%7B%22bitablePerm%22%3A%7B%22tableId%22%3A%22tblBJyX6jZteblYv%22%2C%22rev%22%3A90%7D%7D",
            "type": "image/jpeg",
            "url": "https://open.feishu.cn/open-apis/drive/v1/medias/Vl3FbVk11owlgpxpqsAbBrtFcrd/download?extra=%7B%22bitablePerm%22%3A%7B%22tableId%22%3A%22tblBJyX6jZteblYv%22%2C%22rev%22%3A90%7D%7D"
        }],
        "单向关联": [{
            "record_ids": ["recnVYsuqV"],
            "table_id": "tblBJyX6jZteblYv",
            "text": "索引列多行文本类型",
            "text_arr": ["索引列多行文本类型"],
            "type": "text"
        }],
        "双向关联": [{
            "record_ids": ["recG70uhxh"],
            "table_id": "tblBJyX6jZteblYv",
            "text": "索引列多行文本类型",
            "text_arr": ["索引列多行文本类型"],
            "type": "text"
        }],
        "地理位置": {
            "address": "东长安街",
            "adname": "东城区",
            "cityname": "北京市",
            "full_address": "天安门广场，北京市东城区东长安街",
            "location": "116.397755,39.903179",
            "name": "天安门广场",
            "pname": "北京市"
        },
        "公式": [{
            "text": "false",
            "type": "text"
        }],
        "创建时间": 1675244156000,
        "更新时间": 1677556020000,
        "修改人": {
            "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/06d568cb-f464-4c2e-bd03-76512c545c5j~?image_size=72x72&cut_type=default-face&quality=&format=jpeg&sticker_format=.webp",
            "email": "",
            "en_name": "测试1",
            "id": "ou_92945f86a98bba075174776959c90eda",
            "name": "测试1"
        },
        "创建人": {
            "avatar_url": "https://internal-api-lark-file.feishu.cn/static-resource/v1/06d568cb-f464-4c2e-bd03-76512c545c5j~?image_size=72x72&cut_type=default-face&quality=&format=jpeg&sticker_format=.webp",
            "email": "",
            "en_name": "测试1",
            "id": "ou_92945f86a98bba075174776959c90eda",
            "name": "测试1"
        },
        "条码": "123",
        "查找引用": [{
            "text": "多行文本内容1",
            "type": "text"
        }],
        "自动编号-自定义": "017no20230201",
        "自动编号-默认": "17",
        "货币": "1",
        "进度": "0.66",
        "评分":"3"
    }
}]}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}