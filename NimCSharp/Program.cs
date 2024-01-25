


using NimCSharp.model;
using NimCSharp.Views;

List<List<stickModel>> stickList = new List<List<stickModel>>();
stickModel stick1 = new stickModel(1, 1, 1, true);
stickModel stick2 = new stickModel(2, 1, 2, true);
stickModel stick3 = new stickModel(3, 2, 2, true);
stickModel stick4 = new stickModel(4, 1, 3, true);
stickModel stick5 = new stickModel(5, 2, 3, true);
stickModel stick6 = new stickModel(6, 3, 3, true);

List<stickModel> row1 = new List<stickModel>();
row1.Add(stick1);
List<stickModel> row2 = new List<stickModel>();
row2.Add(stick2);
row2.Add(stick3);
List<stickModel> row3 = new List<stickModel>();
row3.Add(stick4);
row3.Add(stick5);
row3.Add(stick6);

boardModel board = new boardModel(1, stickList);
boardView boardView = new boardView();
boardView.printBoard(board);
