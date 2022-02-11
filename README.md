# cb-tads-interview

Thank you for your interest in our company.

To complete this portion of the interview, clone the repo, create a branch for your changes, apply the new code, commit, and push back up to the repository

### Question 1
The classes `Button`, `Button2` and `Input` will return HTML strings, but the implementation is not in place. 

Using the best coding standards to your ability (paying special attention to the [DRY Principle](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself)), write the implementation of each class. You are allowed to create more classes if you would like.

Your code should cause the unit tests in `HtmlWriterTests` to all pass.


### Question 2
The method `WeekCalculator.DescribeDays()` receives a list of day selections, and should output a string description of the selected days. Similar to when you set an alarm on an iPhone and select the days which the alarm will play.

Write an algorithm in `WeekCalculator.DescribeDays()` that converts selections of days of the week into a string that describes the selection with the following output specifications:
* No selection: "none"
* Only weekend days selected: "Weekends"
* Only week days selected: "Week Days"
* All days selected: "Every Day"
* If none of the above apply, a space delimited list of shortened names of the selected days. For example "Mon Tue Wed"
