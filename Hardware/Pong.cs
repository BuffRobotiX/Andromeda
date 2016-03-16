using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace Hardware
{
    public class Pong
    {
        int paddleHeight = 20;
        static int paddleWidth = 10;
        int leftY = 0;
        int leftX = 10;
        int rightY = 0;
        int rightX = Display.GetWidth() - 10 - paddleWidth;
        int ballX = 50;
        int ballY = 50;
        int ballVelocityX = 1;
        int ballVelocityY = 1;
        PIT pit;
        PIT.PITTimer timer;
        PIT.PITTimer.dOnTrigger trigger;

        public Pong()
        {
            pit = new PIT();
            trigger = new PIT.PITTimer.dOnTrigger(Step);
            timer = new PIT.PITTimer(Step, 1, false);
            pit.RegisterTimer(timer);
            pit.HandleInterrupt();
        }

        public void Step()
        {
            leftY = Mouse.GetY();
            rightY = ballY;
            if (BallInLeft() || BallInRight())
            {
                ballVelocityX = -ballVelocityX;
                //ballVelocityY = -ballVelocityY;
            }
            ballX += ballVelocityX;
            ballY += ballVelocityY;

            Display.DrawFilledRectangle(leftX, leftY, leftX + paddleWidth, leftY + paddleHeight, 7);
            Display.DrawFilledRectangle(rightX, rightY, rightX + paddleWidth, rightY + paddleHeight, 7);
            Display.SetPixel(ballX, ballY, 7);
            Display.SetPixel(ballX + 1, ballY, 7);
            Display.SetPixel(ballX, ballY + 1, 7);
            Display.SetPixel(ballX + 1, ballY + 1, 7);
            //timer = new PIT.PITTimer(Step, 1, false);
            pit.RegisterTimer(timer);
            pit.HandleInterrupt();
        }

        public bool BallInLeft()
        {
            return (ballX > leftX && ballX < leftX + paddleWidth) && (ballY > leftY && ballY < leftY + paddleHeight);
        }

        public bool BallInRight()
        {
            return (ballX > rightX && ballX < rightX + paddleWidth) && (ballY > rightY && ballY < rightY + paddleHeight);
        }
    }
}
