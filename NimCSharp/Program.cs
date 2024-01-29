


using NimCSharp.model;
using NimCSharp.Views;
using NimCSharp.Controllers;


GameManager gameManager = new GameManager();
gameManager.startMenu();











//void boardTest()
//{
//    List<List<stickModel>> stickList = new List<List<stickModel>>();
//    stickModel stick1 = new stickModel(1, 1, 1, true);
//    stickModel stick2 = new stickModel(2, 1, 2, true);
//    stickModel stick3 = new stickModel(3, 2, 2, true);
//    stickModel stick4 = new stickModel(4, 1, 3, true);
//    stickModel stick5 = new stickModel(5, 2, 3, true);
//    stickModel stick6 = new stickModel(6, 3, 3, true);
//    stickModel stick7 = new stickModel(7, 1, 4, true);
//    stickModel stick8 = new stickModel(8, 2, 4, true);
//    stickModel stick9 = new stickModel(9, 3, 4, true);
//    stickModel stick10 = new stickModel(10, 4, 4, true);
//    stickModel stick11 = new stickModel(11, 1, 5, true);
//    stickModel stick12 = new stickModel(12, 2, 5, true);
//    stickModel stick13 = new stickModel(13, 3, 5, true);
//    stickModel stick14 = new stickModel(14, 4, 5, true);
//    stickModel stick15 = new stickModel(15, 5, 5, true);


//    List<stickModel> row1 = new List<stickModel>();
//    row1.Add(stick1);
//    List<stickModel> row2 = new List<stickModel>();
//    row2.Add(stick2);
//    row2.Add(stick3);
//    List<stickModel> row3 = new List<stickModel>();
//    row3.Add(stick4);
//    row3.Add(stick5);
//    row3.Add(stick6);
//    List<stickModel> row4 = new List<stickModel>();
//    row4.Add(stick7);
//    row4.Add(stick8);
//    row4.Add(stick9);
//    row4.Add(stick10);
//    List<stickModel> row5 = new List<stickModel>();
//    row5.Add(stick11);
//    row5.Add(stick12);
//    row5.Add(stick13);
//    row5.Add(stick14);
//    row5.Add(stick15);

//    stickList.Add(row1);
//    stickList.Add(row2);
//    stickList.Add(row3);
//    stickList.Add(row4);
//    stickList.Add(row5);


//    boardModel board = new boardModel(1, stickList);
//    boardView boardView = new boardView();
//    boardView.printBoard(board);
//}