// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_GetCorehrV2SignatureFilesListByBizIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据流程获取电子签文件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据流程获取电子签文件信息 响应体
/// <para>接口ID：7398535900936847363</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list_by_biz_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2flist_by_biz_id</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2SignatureFilesListByBizIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "signature_files": [
            {
                "signature_file_id": "7147527056140813828",
                "names": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "create_time": "2023-01-01 00:00:00",
                "update_time": "2023-01-01 00:00:00",
                "employment_id": "7123132668099919891",
                "pre_hire_id": "7123132668099919891",
                "signature_file_state": {
                    "enum_name": "pending_sign",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "待签字"
                        }
                    ]
                },
                "contract_code": "48793beea04f4e2583d50732e481d507",
                "effective_date": "2024-12-01",
                "template_id": "7147527056140813828",
                "sign_url": "https://www.letsign.com/v2/saas/sign?signCode=05325cb58b77484f92d4b145c18222cf&taskCode=batch-0-4639de2ddcb54439b7f31517a17b7b4c"
            }
        ],
        "batch_sign_url": "https://www.letsign.com/v2/saas/sign?signCode=05325cb58b77484f92d4b145c18222cf&taskCode=batch-0-4639de2ddcb54439b7f31517a17b7b4c"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2SignatureFilesListByBizIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}