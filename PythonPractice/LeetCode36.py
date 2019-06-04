class Solution(object):
    def isValidSudoku(self, board):
        """
        :type board: List[List[str]]
        :rtype: bool
        """
        rSums = [0] * 9
        cSums = [0] * 9
        sqSums = [0] * 9
        for row in range(0,9):
            for col in range(0,9):
                square = (row//3) * 3 + (col//3)
                testNum = board[row][col]
                if not testNum == ".":
                    testNum = 2 ** (int(testNum) - 1)
                    
                    if testNum & rSums[row] == 0:
                        rSums[row] = rSums[row] + testNum
                    else:
                        print("Row Conflict")
                        print(board[row][col], row)
                        return False
                    
                    if testNum & cSums[col] == 0:
                        cSums[col] = cSums[col] + testNum
                    else:
                        print("Col Conflict")
                        print(board[row][col], col)
                        return False
                    
                    if testNum & sqSums[square] == 0:
                        sqSums[square] = sqSums[square] + testNum
                    else:
                        print("Square Conflict")
                        print(board[row][col], square)
                        return False   
        return True