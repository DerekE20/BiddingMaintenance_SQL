
INSERT INTO action (ActionId, Description,
SystemRef,
StageRef,
Sequence,
SuitActionRef,
ShapeActionRef,
ProtectiveActionRef,
ConventionRef,
OpponentBidActionRef,
PartnerBidActionRef,
SuitQualityActionRef,
FourCardMajorActionRef,
BalancedActionRef,
ltcActionRef)
SELECT ActionId+68, Description,
SystemRef,
StageRef,
Sequence,
SuitActionRef,
ShapeActionRef,
ProtectiveActionRef,
ConventionRef,
OpponentBidActionRef,
PartnerBidActionRef,
SuitQualityActionRef,
FourCardMajorActionRef,
BalancedActionRef,
ltcActionRef
FROM action
WHERE (actionid<69 and actionid>34)
UPDATE action set systemRef=3 where actionid>68