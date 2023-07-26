# Branches in this (Clare's) fork of this repo:

- [`extract-method`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/extract-method) - Created for O'Reilly bootcamp
    - Shows the result of extracting methods in TennisGame3
    - See Tennis3-extract-method.mov (https://tinyurl.com/extract-method)
- [`extract-method-demo`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/extract-method-demo) - Created for O'Reilly bootcamp
    - Shows the result of extracting methods in TennisGame1
- [`tbd-demo-1`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/tbd-demo-1)
    - Might only exist locally! Generally deleted after course.
    - Used during O'Reilly Refactoring for Continuous Delivery
    - The idea was that I have two different copies of the repo, to emulate two different pairs of devs
    - Each pair would push/pull to/from the same branch
    - In real life this would be `main`, but I'm deliberately keeping `main` clear in this fork
- [`main1`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/main1)
    - Might only exist locally! Generally deleted after course.
    - Created while demoing a TBD exercise during O'Reilly Refactoring for Continuous Delivery
    - The idea was that participants could keep switching between branches `main1` and `main2`
    - This would then emulate two pairs working on the same branch, without needing the extra overhead of two code bases and pushing to a server as I did with my `tbd-demo-1` demo (see above)
- [`main2`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/main2)
    - Might only exist locally! Generally deleted after course.
    - Created while demoing a TBD exercise during O'Reilly Refactoring for Continuous Delivery
    - See notes for `main1` above
- [`extract-methods`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/extract-methods)
    - Might only exist locally! Generally deleted after course.
    - Created while demoing a merging exercise during O'Reilly Refactoring for Continuous Delivery
    - Participants were asked to create this branch and `rename-vars` (see below)
    - Did different things in each branch
    - The intention is that merging the two will be hard
- [`rename-vars`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/rename-vars)
    - Might only exist locally! Generally deleted after course.
    - Created while demoing a merging exercise during O'Reilly Refactoring for Continuous Delivery
    - Participants were asked to create this branch and `extract-methods` (see above)
    - Did different things in each branch
    - The intention is that merging the two will be hard
- [`refactoring-with-resharper`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/refactoring-with-resharper)
    - has some extracted methods
    - renamed vars
    - also has Player class, which most of the other branches don't
    - was presumably created while making Tennis3-Refactoring-With-Resharper.mp4 (see [coding videos](/organising/private/career/sudbery-software/coding-videos.md))
- [`resharper-demo-v2`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/resharper-demo-v2)
    - has some extracted methods
    - renamed vars
    - also has Player class, which none of the other branches do
    - v similar to `refactoring-with-resharper`
    - I suspect I redid the demo, doing tings slightly differently
- [`mmmss-demo`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/mmmss-demo)
    - Created for O'Reilly Refactoring 2
    - Just has variable renaming in TennisGame2
    - and methods moved around
- [`mmmss-demo-jun-23-23`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/mmmss-demo-jun-23-23)
    - Created during demo section of June '23 delivery of Refactoring for Continuous Delivery (O'Reilly)
- [`mmmss-demo-live-18-aug-22`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/mmmss-demo-live-18-aug-22)
    - Created during O'Reilly Refactoring 2, Aug '22
    - has variable renaming in TennisGame2
    - and methods moved around
    - but also two constructors cos I was demoing backwards compatibility
- [`feature-flags-start`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/feature-flags-start)
    - Starting point for adding an isPinklish flag to TennisGame2
    - Was created for O'Reilly refactoring 2
    - Gives participants a bit of a headstart by giving them test data
    - In test file, `PinklishTestDataGenerator` is fully translated
    - Flag has been introduced to TennisGame2, but no other code has been added or implemented
- [`feature-flags-demo-start`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/feature-flags-demo-start)
    - Starting point for adding an isPinklish flag to TennisGame2
    - Currently (June '23) nearly same as `feature-flags-demo-partway` (apart from `PinklishTestDataGenerator`)
    - I orginally created this for my use while doing demo in Refactoring Part 2 (O'Reilly)
    - Flag has been introduced to TennisGame2
    - Lookup function has been added
    - English and Pinklish dictionaries both exist, but only contain one word each
    - In test file, `PinklishTestDataGenerator` contains no translations
- [`feature-flags-demo-partway`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/feature-flags-demo-partway)
    - Shows the result of starting to add an isPinklish flag to TennisGame2
    - Flag has been introduced to TennisGame2
    - Lookup function has been added
    - English and Pinklish dictionaries both exist, but only contain one word each
    - In test file, `PinklishTestDataGenerator` contains one translation (Love => Like)
- [`feature-flags-demo`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/feature-flags-demo)
    - Shows the result of adding an isPinklish flag to TennisGame2
    - Fully implemented
- [`feature-flags-demo-finished`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/feature-flags-demo-finished)
    - Shows the result of adding an isPinklish flag to TennisGame2
    - Fully implemented
    - Almost same as `feature-flags-demo`, but `PinklishWIPTestDataGenerator` has been removed from test file
- [`parallel-change-demo`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/parallel-change-demo)
    - Used in O'Reilly Quality Code bootcamp for the parallel change learning hour
    - Used to demonstrate adding and keeping old and new constructor in parallel while migration completed 
    - Based on `feature-flags-demo-finished`, which has an `isPinklish` flag added to `TennisGame2` constructor
    - To create this branch I took the `isPinklish` flag away from the constructor
    - The idea is I check out this branch for the demo, and add the flag back in again
- [`lift-up-conditional`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/lift-up-conditional)
    - Looks like I had a go at doing lift up conditional in TenisGame2
    - See call to Temp()
    - Doesn't look like I got very far though
- [`scratch-01`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/scratch-01)
    - Presumably disposable, prob created during O'Reilly course
    - Changed code is in TennisGame2
    - Looks v similar to `mmmss-demo`
- [`when-to-refactor`](https://github.com/claresudbery/Tennis-Refactoring-Kata/blob/when-to-refactor)
    - Created during Siemens learning hour   
    - TennisGame3 has renamed vars
    - points_to_string array created
    - One method extracted
    - This is the code behind the video: Tennis-Refactoring-easier-to-understand-and-cheaper-to-modify
        -  (see [coding videos](/organising/private/career/sudbery-software/coding-videos.md))

# Tennis Refactoring Kata

Imagine you work for a consultancy company, and one of your colleagues has been doing some work for the Tennis Society. The contract is for 10 hours billable work, and your colleague has spent 8.5 hours working on it. Unfortunately he has now fallen ill. He says he has completed the work, and the tests all pass. Your boss has asked you to take over from him. She wants you to spend an hour or so on the code so she can bill the client for the full 10 hours. She instructs you to tidy up the code a little and perhaps make some notes so you can give your colleague some feedback on his chosen design. You should also prepare to talk to your boss about the value of this refactoring work, over and above the extra billable hours.

There are three versions of this refactoring kata, each with their own design smells and challenges. I suggest you start with the first one, with the class "TennisGame1". The test suite provided is fairly comprehensive, and fast to run. You should not need to change the tests, only run them often as you refactor.

If you like this Kata, you may be interested in [my books](https://leanpub.com/u/emilybache) and website [SammanCoaching.org](https://sammancoaching.org)

## Kata Description

Here is a description of the problem this code is designed to solve: [Tennis Kata](https://sammancoaching.org/kata_descriptions/tennis.html).

## Questions to discuss afterwards

* How did it feel to work with such fast, comprehensive tests?
* Did you make mistakes while refactoring that were caught by the tests?
* If you used a tool to record your test runs, review it. Could you have taken smaller steps? Made fewer refactoring mistakes?
* Did you ever make any refactoring mistakes and then back out your changes? How did it feel to throw away code?
* What would you say to your colleague if they had written this code?
* What would you say to your boss about the value of this refactoring work? Was there more reason to do it over and above the extra billable hour or so?
