DECLARE @i INT;

SET @i = (select (max(BidId)) from bid);

INSERT into Bid
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
WHERE BidId<@i;

UPDATE bid set systemRef=2 where bidid>@i
