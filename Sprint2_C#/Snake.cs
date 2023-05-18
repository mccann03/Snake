
/*Code that sets up library for game.*/
using System;
using system.ComponentModel;
using system.drawing;
using system.data;
using system.linq;
using system.text;
using system.collections.generic;
using system.Threading.Tasks;
using system.collections;
using Windows.Forms;

namespace snake
{
    class PlayerPosition
    /*Code getting snake position in terms fo X and Y.*/
    {
        public int x { get; set; } 
        public int y { get; set; }
    };
    /*Class that creates directional constansts.*/
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    };
    /*Code that starts game.*/
    class GameBegin
    {
        settings();
        snake.Clear();
        PlayerPosition SnakeHead = new PlayerPosition { x = 8, y = 3};
        snake.add(PlayerPosition);
    }
    /*updates player position and game status*/
    class UpdatePosition {
        if (settings.game_over == true)
        {

        }
        if (input.KeyboardPress(Keys.Right) && settings.default_direction != Direction.Left)
        {
            settings.default_direction = Direction.Right;
        }
        elif (input.KeyboardPress(Keys.Left) && settings.default_direction != Direction.Right)
        {
            settings.default_direction = Direction.Left;
        }
        elif (input.KeyboardPress(Keys.up) && settings.default_direction != Direction.Down)
        {
            settings.default_direction = Direction.up;
        }
        elif (input.KeyboardPress(Keys.Down) && settings.default_direction != Direction.up)
        {
            settings.default_direction = Direction.Down;
        }
        Movement();
    }
    /*Code creating the settings that determine and affect various aspects of the game.*/
    class settings
    {
        public const int width = 32;
        public const int height = 16;
        public const int speed = 10;
        public const int score = 0;
        public const int points = 10;
        public const int game_over = false;
        public const int default_direction = Direction.Down;
    }
    /*Determines what direction snake should go based on what keys are pressed, and Behavior
      for things like food and game over. */
    class MovementAndBehavior
    {
        for (int i = SnakeHead.Count - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                switch (settings.Direction)
                {
                    case Direction.Right:
                        SnakeHead[i].x++;
                        break;
                    case Direction.Left:
                        SnakeHead[i].x--;
                        break;
                    case Direction.Up:
                        SnakeHead[i].y--;
                        break;
                    case Direction.Down:
                        SnakeHead[i].y++;
                        break;

                }
                int MaxX = pbCanvas.size.width / settings.width;
                int MaxY = pbCanvas.size.height / settings.height;

                if (
                    SnakeHead[i].x < 0 || Snake[i].y < 0 ||
                    SnakeHead[i].x  > MaxX || snake[i].y > MaxY
                )
                {
                    GameEnd();
                }
                for (int j = 1; j < SnakeBody.Count; j++)
                {
                    if (SnakeBody[i].x == SnakeBody[j].x && SnakeBody[i].y == SnakeBody[j].y)
                    {
                        GameEnd();
                    }
                }
            }
            if (SnakeBody[0].x == FoodPlace.x && SnakeBody[0].y == FoodPlace.y)
            {
                eat();
            }
        }
        else
        {
            SnakeBody[i].x = SnakeBody[i - 1].x;
            SnakeBody[i].y = SnakeBody[i - 1].y;
        }
    };
    /*Code that enables keyboard input.*/
    class input
    {
        static HashTable KeyboardTable = new HashTable();
        static bool KeyboardPress(Keys key)
        {
            if (KeyboardTable[key] == null)
            {
                return false;
            }
            return (bool)KeyboardTable[key];
        }
        static void KeyboardChange (Keys key, bool change)
        {
        KeyboardTable[key] = change;
        }
    };
    /*Code to create snake*/
    class PlayerCharacter
    {
        for (i = 0; i < SnakeBody.count(); i++)
        {
            new.rectangle (snake[i].x * settings.width, snake[i].y * settings.height,
            settings.width, settings.height);
        }
    };
    /*Generates food for the snake to eat.*/
    class food
    {
        int MaxX = pbCanvas.size.width / settings.width;
        int MaxY = pdCanvas.size.height / settings.height;
        random FoodPlace = new random();
        food = new rectangle { X = FoodPlace.Next (0, MaxX), Y = FoodPlace(0, MaxY)};
    };
    /*Snake eats food and grows longer.*/
    class eat
    {
        PlayerPosition SnakeBody = new PlayerPosition
        {
            X = snake[snake.count + 1].X
            Y = snake[snake.count + 1].Y
        };
        snake.add(SnakeBody);
        settings.score += settings.score;
        PositionTwo.text = settings.score.ToString();
        food();
    };
    /*Code to dtermine when the game over is intiated.*/
    class GameEnd 
    {
        settings.game_over = true;
    };
}