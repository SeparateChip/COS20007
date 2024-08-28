from Counter import Counter

class Clock:
    def __init__(self):
        self.seconds = Counter("Seconds")
        self.minutes = Counter("Minutes")
        self.hours = Counter("Hours")

    def tick(self):
        self.seconds.increment()
        if self.seconds.tick > 59:
            self.minutes.increment()
            self.seconds.reset()  
            if self.minutes.tick > 59:
                self.hours.increment()
                self.minutes.reset()  
                if self.hours.tick > 23:
                    self.reset()

    def reset(self):
        self.seconds.reset()
        self.minutes.reset()
        self.hours.reset()

    def time(self):
        return f"{self.hours.tick:02d}:{self.minutes.tick:02d}:{self.seconds.tick:02d}"
