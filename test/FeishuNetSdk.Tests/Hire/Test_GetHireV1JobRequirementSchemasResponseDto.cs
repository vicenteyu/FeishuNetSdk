// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobRequirementSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取招聘需求模板列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘需求模板列表 响应体
/// <para>接口ID：6989078472837234691</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement_schema%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobRequirementSchemasResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "msg": "ok",
  "data": {
    "items": [
      {
        "id": "6949805467799537964",
        "name": {
          "zh_cn": "关键职位招聘需求模板",
          "en_us": "Recruitment requirements template for key positions"
        },
        "object_list": [
          {
            "id": "6949805467799537964",
            "name": {
              "zh_cn": "默认模块",
              "en_us": "Default module"
            },
            "description": {
              "zh_cn": "通用模块，包含招聘需求的基础字段",
              "en_us": "Generic modules that contain the basic fields of recruitment requirements"
            },
            "setting": {
              "object_type": 11,
              "config": null
            },
            "is_customized": true,
            "is_required": false,
            "active_status": 1,
            "children_list": [
              {
                "id": "6949805467799537964",
                "name": {
                  "zh_cn": "工作地点",
                  "en_us": "workplace"
                },
                "description": {
                  "zh_cn": "工作地点",
                  "en_us": "workplace"
                },
                "setting": {
                  "object_type": 1,
                  "config": {
                    "options": [
                      {
                        "key": "Beijing",
                        "name": {
                          "zh_cn": "北京",
                          "en_us": "Beijing"
                        },
                        "description": {
                          "zh_cn": "北京",
                          "en_us": "Beijing"
                        },
                        "active_status": 1
                      }
                    ]
                  }
                },
                "parent_id": "6949805467799537964",
                "is_customized": true,
                "is_required": false,
                "active_status": 1
              }
            ]
          }
        ]
      }
    ],
    "has_more": true,
    "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1NTUyMjM2NzIsImlkIjpudWxsfQ"
  }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobRequirementSchemasResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}