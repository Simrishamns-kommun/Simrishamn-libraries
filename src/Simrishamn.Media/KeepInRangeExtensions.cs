// The code in this file is based on code created by MudBlazor and is licensed under the MIT License.

//MIT License

//Copyright (c) 2021 MudBlazor

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

namespace Simrishamn.Media.Extensions;

#nullable enable
public static class KeepInRangeExtensions
{
    public static double EnsureRange(this double input, double max) => EnsureRange(input, 0.0, max);
    public static double EnsureRange(this double input, double min, double max) => Math.Max(min, Math.Min(max, input));
    public static byte EnsureRange(this byte input, byte max) => EnsureRange(input, (byte)0, max);
    public static byte EnsureRange(this byte input, byte min, byte max) => Math.Max(min, Math.Min(max, input));
    public static byte EnsureRangeToByte(this int input) => (byte)EnsureRange(input, 0, 255);
    public static int EnsureRange(this int input, int max) => EnsureRange(input, 0, max);
    public static int EnsureRange(this int input, int min, int max) => Math.Max(min, Math.Min(max, input));
}