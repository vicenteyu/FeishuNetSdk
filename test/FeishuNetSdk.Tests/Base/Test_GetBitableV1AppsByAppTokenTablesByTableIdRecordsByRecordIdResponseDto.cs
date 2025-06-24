// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 检索记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 检索记录 响应体
/// <para>接口ID：6952707657162588162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fget</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "data":{
        "record":{
            "fields":{
                "人力耗时":64,
                "人力评估":"8",
                "任务执行人":[
                    {
                        "email":"huangpaopao@feishu.cn",
                        "en_name":"Paopao Huang",
                        "id":"ou_5fb00e0112212cc7012fe3a697336989",
                        "name":"黄泡泡"
                    }
                ],
                "任务描述":"我是最大的功能开发🥕",
                "任务附件":[
                    {
                        "file_token":"boxcnkQWfV4XbHwzDngmezMGzXe",
                        "name":"2.gif",
                        "size":10250625,
                        "tmp_url":"https://open.feishu.cn/open-apis/drive/v1/medias/batch_get_tmp_download_url?file_tokens=boxcnkQWfV4XbHwzDngmezMGzXe",
                        "type":"image/gif",
                        "url":"https://open.feishu.cn/open-apis/drive/v1/medias/boxcnkQWfV4XbHwzDngmezMGzXe/download"
                    }
                ],
                "对应 OKR":[
                    {
                        "text":"新功能评审",
                        "type":"text"
                    }
                ],
                "截止日期":1612108800000,
                "文档地址":{
                    "link":"https://example.feishu.cn/drive/home/",
                    "text":"文档备份"
                },
                "是否完成":false,
                "状态":"开发中",
                "相关部门":[
                    "研发"
                ],
                "多行文本":[
                    {
                        "text":"hello",
                        "type":"text"
                    },
                    {
                        "mentionType":"User",
                        "mentionNotify":false,
                        "name":"test",
                        "text":"@test",
                        "token":"ou_sfsdfsdfsdfsdfdsfsdfdsf",
                        "type":"mention"
                    },
                    {
                        "link":"https://test-sasdfsfsd.feishu-boe.cn/base/basbcq2aFvW8nFJpfOXa1111111",
                        "mentionType":"Bitable",
                        "text":"未命名多维表格",
                        "token":"basbcq2aFvW8nFJpfOXalx57ffb",
                        "type":"mention"
                    },
                    {
                        "text":"测试链接标题",
                        "link":"https://www.baidu.com/",
                        "type":"url"
                    }
                ],
                "单向关联":[
                    {
                        "type":"text",
                        "table_id":"tbltAvx3DYBw7PVj",
                        "record_ids":[
                          "recl1IWVnB"
                        ],
                        "text":"第一行"
                    }
                ],
                "双向关联":[
                    {
                        "table_id":"tbltAvx3DYBw7PVj",
                        "record_ids":[
                          "recl1IWVnB",
                          "recrJk7SXT"
                        ],
                        "text":"第一行,第二行",
                        "type":"text"
                    }
                ]
            },
            "record_id":"recn0hoyXL",
            "record_url": "https://example.feishu.cn/record/1sfvuxxxxxxxxxxxxxKdupE5Q"
        }
    },
    "msg":"Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}