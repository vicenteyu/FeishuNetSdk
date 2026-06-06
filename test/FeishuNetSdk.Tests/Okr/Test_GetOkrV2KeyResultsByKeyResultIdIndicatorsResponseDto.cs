// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_GetOkrV2KeyResultsByKeyResultIdIndicatorsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取关键结果的量化指标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取关键结果的量化指标 响应体
/// <para>接口ID：7644764969658403788</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-key_result-indicator/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-key_result-indicator%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV2KeyResultsByKeyResultIdIndicatorsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "indicator": {
            "id": "7342342398472398473",
            "create_time": "1760604634563",
            "update_time": "1760604634563",
            "owner": {
                "owner_type": "user",
                "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
            },
            "entity_type": 2,
            "entity_id": "7342342398472398473",
            "indicator_status": 0,
            "status_calculate_type": 0,
            "start_value": 0,
            "target_value": 0,
            "current_value": 0,
            "current_value_calculate_type": 0,
            "unit": {
                "unit_type": 0,
                "unit_value": "PERCENT"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV2KeyResultsByKeyResultIdIndicatorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}