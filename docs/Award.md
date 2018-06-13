# com.tweirtx.tba-api-v3-client.Model.Award
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the award as provided by FIRST. May vary for the same award type. | 
**AwardType** | **int?** | Type of award given. See https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/award_type.py#L6 | 
**EventKey** | **string** | The event_key of the event the award was won at. | 
**RecipientList** | [**List&lt;AwardRecipient&gt;**](AwardRecipient.md) | A list of recipients of the award at the event. Either team_key and/or awardee for individual awards. | 
**Year** | **int?** | The year this award was won. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

