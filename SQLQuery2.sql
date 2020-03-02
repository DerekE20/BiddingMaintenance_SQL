DECLARE @i INT;
SET @i = (select (max(BidId)) from bid);
INSERT into bid
(BidId,
SystemRef,
BidName,
Description,
SuitRef,
StageRef,
ShapeRef,
PointRangeRef,
ltcRef,
BidBoxRef,
ConventionRef,
Protective,
OpponentBidRef,
PartnerBidRef,
SuitQualityRef,
FourCardMajorRef,
Balanced)
SELECT BidId+@i,
SystemRef,
BidName,
Description,
SuitRef,
StageRef,
ShapeRef,
PointRangeRef,
ltcRef,
BidBoxRef,
ConventionRef,
Protective,
OpponentBidRef,
PartnerBidRef,
SuitQualityRef,
FourCardMajorRef,
Balanced
FROM bid
WHERE SystemRef = 1;

UPDATE bid set systemRef=3 where BidId>@i