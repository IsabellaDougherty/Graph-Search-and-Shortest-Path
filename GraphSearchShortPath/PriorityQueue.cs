using System;

public class PriorityQueue
{
    private int?[] priorityArray = new int?[100];

    public int?[] PriorityArray
    {
        get
        {
            return priorityArray;
        }

        set
        {
            priorityArray = value;
        }
    }
    //IAD 10/15/2024: Logic for insertion into the data structure
    public void insert(int newNum)
    {
        priorityArray[0] = (int?)newNum;

        for (int i = 0; i < priorityArray.Length; i++)
        {
            if (priorityArray[i] == null)
            {
                priorityArray[i] = newNum;
                break;
            }
        }

        int count = getEndOfArrayIndex();
        while (count > 1)
        {
            int parent = 0;
            if (count % 2 == 0)
            {
                parent = count / 2;
            }
            else
            {
                parent = (int)Math.Floor((double)count / 2);
            }

            if (PriorityArray[parent] > PriorityArray[count])
            {
                int? temp = PriorityArray[count];
                PriorityArray[count] = PriorityArray[parent];
                PriorityArray[parent] = temp;
            }

            count--;
        }

        updateDisplay();
    }
    //IAD 10/15/2024: Logic for updating the display of the data structure
    public string updateDisplay()
    {
        string newDisplay = "";
        int row = 0;
        int lastIndex = getEndOfArrayIndex();

        for (int i = 1; i < lastIndex;)
        {
            int numSpaces = 60;
            int leftOffest = 18 * row;
            for (int k = 0; k < (numSpaces - leftOffest); k++)
            {
                newDisplay += " ";
            }

            for (int j = 0; j < Math.Pow(2, row); j++)
            {
                if (i >= PriorityArray.Length)
                    break;

                string spacesBetween = defineSpaceSize(row, leftOffest);
                newDisplay += PriorityArray[i].ToString() + spacesBetween;
                i++;
            }

            row++;
            newDisplay += "\n";
        }

        return newDisplay;
    }
    public string defineSpaceSize(int row, int offset)
    {
        string spaceSize = "";
        int defaultSpaces = 20;
        if (row != 0)
        {
            for (int i = 0; i < defaultSpaces / row; i++)
            {
                spaceSize += "  ";
            }
        }
        return spaceSize;
    }
    public int getEndOfArrayIndex()
    {
        int lastIndex = 0;
        for (int i = 0; i < PriorityArray.Length; i++)
        {
            if (PriorityArray[i] == null)
            {
                lastIndex = i;
                break;
            }

        }
        return lastIndex;
    }
    public void delete()
    {
        int lastEntry = getEndOfArrayIndex();
        PriorityArray[1] = PriorityArray[lastEntry - 1];
        PriorityArray[lastEntry - 1] = null;

        int count = 1;
        while (count < getEndOfArrayIndex())
        {
            //Choose child to swap with
            int chosenChild = 0;
            int leftChild = count * 2;
            int rightChild = (count * 2) + 1;
            if (PriorityArray[rightChild] == null && PriorityArray[leftChild] != null)
            {
                chosenChild = leftChild;
            }

            else if (PriorityArray[rightChild] == null && PriorityArray[leftChild] == null)
            {
                chosenChild = 0;
            }
            else if (PriorityArray[rightChild] != null && PriorityArray[leftChild] != null)
            {
                if (PriorityArray[leftChild] <= PriorityArray[rightChild])
                {
                    chosenChild = leftChild;
                }
                else
                {
                    chosenChild = rightChild;
                }
            }

            //Swap if needed
            if (PriorityArray[chosenChild] <= PriorityArray[count] && chosenChild > 0)
            {
                int? temp = PriorityArray[count];
                PriorityArray[count] = PriorityArray[chosenChild];
                PriorityArray[chosenChild] = temp;
            }

            count++;
        }
        updateDisplay();
    }

    public void delete(int entry)
    {
        int lastEntry = getEndOfArrayIndex();
        PriorityArray[1] = PriorityArray[lastEntry - 1];
        PriorityArray[lastEntry - 1] = null;

        int count = 1;
        while (count < getEndOfArrayIndex())
        {
            //Choose child to swap with
            int chosenChild = 0;
            int leftChild = count * 2;
            int rightChild = (count * 2) + 1;
            if (PriorityArray[rightChild] == null && PriorityArray[leftChild] != null)
            {
                chosenChild = leftChild;
            }

            else if (PriorityArray[rightChild] == null && PriorityArray[leftChild] == null)
            {
                chosenChild = 0;
            }
            else if (PriorityArray[rightChild] != null && PriorityArray[leftChild] != null)
            {
                if (PriorityArray[leftChild] <= PriorityArray[rightChild])
                {
                    chosenChild = leftChild;
                }
                else
                {
                    chosenChild = rightChild;
                }
            }
            //Swap if needed
            if (PriorityArray[chosenChild] <= PriorityArray[count])
            {
                int? temp = PriorityArray[count];
                PriorityArray[count] = PriorityArray[chosenChild];
                PriorityArray[chosenChild] = temp;
            }
            count++;
        }
        updateDisplay();

    }
}
