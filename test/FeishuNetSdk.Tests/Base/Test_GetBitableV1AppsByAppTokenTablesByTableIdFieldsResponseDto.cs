// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出字段 响应体
/// <para>接口ID：6960166873968492547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
                "field_id": "fldYWaldeW",
                "field_name": "多行文本",
                "is_primary": true,
                "property": null,
                "type": 1,
                "ui_type": "Text"
            },
            {
                "field_id": "fldctOury6",
                "field_name": "人员",
                "is_primary": false,
                "property": {
                    "multiple": true
                },
                "type": 11,
                "ui_type": "User"
            },
            {
                "field_id": "fldhAppMQX",
                "field_name": "单选",
                "is_primary": false,
                "property": {
                    "options": [
                        {
                            "color": 0,
                            "id": "opt5XoXIB0",
                            "name": "选项1"
                        }
                    ]
                },
                "type": 3,
                "ui_type": "SingleSelect"
            },
            {
                "field_id": "fldmeqmpVA",
                "field_name": "多选",
                "is_primary": false,
                "property": {
                    "options": [
                        {
                            "color": 0,
                            "id": "opt5XoXIB0",
                            "name": "选项1"
                        },
                        {
                            "color": 1,
                            "id": "optCvWAQfP",
                            "name": "选项2"
                        }
                    ]
                },
                "type": 4,
                "ui_type": "MultiSelect"
            },
            {
                "field_id": "fldXhExGte",
                "field_name": "群组",
                "is_primary": false,
                "property": {
                    "multiple": true
                },
                "type": 23,
                "ui_type": "GroupChat"
            },
            {
                "field_id": "fldUeGSYKO",
                "field_name": "日期",
                "is_primary": false,
                "property": {
                    "auto_fill": false,
                    "date_formatter": "yyyy/MM/dd"
                },
                "type": 5,
                "ui_type": "DateTime"
            },
            {
                "field_id": "fldQfY0kQq",
                "field_name": "附件",
                "is_primary": false,
                "property": null,
                "type": 17,
                "ui_type": "Attachment"
            },
            {
                "field_id": "fldPlbgodf",
                "field_name": "索引",
                "is_primary": false,
                "property": null,
                "type": 1,
                "ui_type": "Text"
            },
            {
                "field_id": "fldJU9aVuL",
                "field_name": "复选框",
                "is_primary": false,
                "property": null,
                "type": 7,
                "ui_type": "Checkbox"
            },
            {
                "field_id": "fldM2XDZx6",
                "field_name": "超链接",
                "is_primary": false,
                "property": null,
                "type": 15,
                "ui_type": "Url"
            },
            {
                "field_id": "fld6oN4ILr",
                "field_name": "电话号码",
                "is_primary": false,
                "property": null,
                "type": 13,
                "ui_type": "Phone"
            },
            {
                "field_id": "fldaQAG9aL",
                "field_name": "数据表",
                "is_primary": false,
                "property": {
                    "multiple": true,
                    "table_id": "tbltDA6cN3ou5r43",
                    "table_name": "数据表"
                },
                "type": 18,
                "ui_type": "SingleLink"
            },
            {
                "field_id": "fldNubyO2U",
                "field_name": "数据表 2",
                "is_primary": false,
                "property": {
                    "back_field_id": "fld0poyvPk",
                    "back_field_name": "数据表 6",
                    "multiple": true,
                    "table_id": "tbltDA6cN3ou5r43",
                    "table_name": "数据表"
                },
                "type": 21,
                "ui_type": "DuplexLink"
            },
            {
                "field_id": "fld2VT2n9r",
                "field_name": "地理位置",
                "is_primary": false,
                "property": {
                    "location": {
                        "input_type": "not_limit"
                    }
                },
                "type": 22,
                "ui_type": "Location"
            },
            {
                "field_id": "fldRITHRhg",
                "field_name": "公式",
                "is_primary": false,
                "property": {
                    "formatter": ""
                },
                "type": 20,
                "ui_type": "Formula"
            },
            {
                "field_id": "fldNM5yXpL",
                "field_name": "创建时间",
                "is_primary": false,
                "property": {
                    "date_formatter": "yyyy/MM/dd"
                },
                "type": 1001,
                "ui_type": "CreatedTime"
            },
            {
                "field_id": "fldhSAWlAT",
                "field_name": "创建人",
                "is_primary": false,
                "property": null,
                "type": 1003,
                "ui_type": "CreatedUser"
            },
            {
                "field_id": "fldksdalhG",
                "field_name": "修改人",
                "is_primary": false,
                "property": null,
                "type": 1004,
                "ui_type": "ModifiedUser"
            },
            {
                "field_id": "fldAXRUmB4",
                "field_name": "最后更新时间",
                "is_primary": false,
                "property": {
                    "date_formatter": "yyyy/MM/dd"
                },
                "type": 1002,
                "ui_type": "ModifiedTime"
            },
            {
                "field_id": "fldfujMlXf",
                "field_name": "条码",
                "is_primary": false,
                "property": {
                    "allowed_edit_modes": {
                        "manual": true,
                        "scan": true
                    }
                },
                "type": 1,
                "ui_type": "Barcode"
            },
            {
                "field_id": "fldiVqhh9r",
                "field_name": "查找引用",
                "is_primary": false,
                "property": null,
                "type": 19,
                "ui_type": "Lookup"
            },
            {
                "field_id": "fld4WsysqF",
                "field_name": "自动编号",
                "is_primary": false,
                "property": {
                    "auto_serial": {
                        "type": "auto_increment_number"
                    }
                },
                "type": 1005,
                "ui_type": "AutoNumber"
            },
            {
                "field_id": "fldMy4SfrI",
                "field_name": "货币",
                "is_primary": false,
                "property": {
                    "currency_code": "CNY",
                    "formatter": "0.00"
                },
                "type": 2,
                "ui_type": "Currency"
            },
            {
                "field_id": "fldj1QnQXO",
                "field_name": "进度",
                "is_primary": false,
                "property": {
                    "formatter": "0%",
                    "max": 1,
                    "min": 0,
                    "range_customize": false
                },
                "type": 2,
                "ui_type": "Progress"
            },
            {
                "field_id": "fldQhSzWbx",
                "field_name": "评分",
                "is_primary": false,
                "property": {
                    "formatter": "0",
                    "max": 5,
                    "min": 1,
                    "rating": {
                        "symbol": "star"
                    }
                },
                "type": 2,
                "ui_type": "Rating"
            }
        ],
        "page_token": "fldQhSzWbx",
        "total": 25
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}