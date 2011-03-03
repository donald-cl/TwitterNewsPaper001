TwitterNewsPaper notes:
-There is a limit that the twitter API can be called: 70 requests within 1 hour<this newspaper app is definitely going above that right now ...

-Need to understand asp.net MVC better to solve problem of repeated tweets being shown. Everytime I call a controller`s index function all of the variables are set to default and so the dictionarys will be empty and only check for duplicates in the single instance it is called. Or so it seems to me, maybe should do some tests.

-Whats the difference between fluent twitter which is being used to request the public timeline and whatever else there is. An API call to get the public time line shouldn`t be taken into account in terms of the 70 requests per hour limit.
