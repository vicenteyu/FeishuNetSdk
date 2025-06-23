namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新多条记录 响应体
/// <para>接口ID：6952707657162539010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "records": [
            {
                "fields": {
                    "人员": [
                        {
                            "id": "ou_2910013f1e6456f16a0ce75ede950a0a"
                        },
                        {
                            "id": "ou_e04138c9633dd0d2ea166d79f548ab5d"
                        }
                    ],
                    "群组": [
                        {
                            "id": "oc_cd07f55f14d6f4a4f1b51504e7e97f48"
                        }
                    ],
                    "单向关联": [
                        "recHTLvO7x",
                        "recbS8zb2m"
                    ],
                    "单选": "选项3",
                    "双向关联": [
                        "recHTLvO7x",
                        "recbS8zb2m"
                    ],
                    "地理位置": "116.397755,39.903179",
                    "复选框": true,
                    "多行文本": "多行文本内容",
                    "多选": [
                        "选项1",
                        "选项2"
                    ],
                    "数字": 100,
                    "日期": 1674206443000,
                    "条码": "qawqe",
                    "电话号码": "13026162666",
                    "索引": "索引列多行文本类型",
                    "超链接": {
                        "link": "https://www.feishu.cn/product/base",
                        "text": "飞书多维表格官网"
                    },
                    "附件": [
                        {
                            "file_token": "Vl3FbVkvnowlgpxpqsAbBrtFcrd"
                        }
                    ],
                    "评分": 3,
                    "货币": 3,
                    "进度": 0.25
                },
                "id": "reclAqylTN",
                "record_id": "reclAqylTN"
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}