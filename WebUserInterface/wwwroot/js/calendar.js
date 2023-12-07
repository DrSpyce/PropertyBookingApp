$(document).ready(function () {
    function getBlockedDatesUntilToday() {
        var today = moment().startOf('day');
        var blockedDates = [];
        for (var d = moment('2022-01-01'); d.isBefore(today); d.add(1, 'day')) {
            blockedDates.push(d.format('YYYY-MM-DD'));
        }
        return blockedDates;
    }

    function getBookedDated() {
        var blockedDatesStart = [];
        var blockedDatesEnd = [];
        var result;
        $('p[id^="start"]').each(function () {
            var dateValue = $(this).text();
            blockedDatesStart.push(dateValue);
        });
        $('p[id^="end"]').each(function () {
            var dateValue = $(this).text();
            blockedDatesEnd.push(dateValue);
        });
        for (let i = 0; i < blockedDatesStart.length; i++) {
            result += ',' + fillDates(blockedDatesStart[i], blockedDatesEnd[i])
        }
        return result;
    }

    function fillDates(start, end) {
        var blockedDate = [];
        for (var d = moment(start); d.isBefore(end); d.add(1, 'day')) {
            blockedDate.push(d.format('YYYY-MM-DD'));
        }
        return blockedDate;
    }

    $('#dateRangePicker').daterangepicker({
        startDate: moment().add(1, 'days'),
        endDate: moment().add(2, 'days'),
        isInvalidDate: function (date) {
            var blockedDates = getBlockedDatesUntilToday();
            var bookedDates = getBookedDated();
            blockedDates += ',' + bookedDates;
            return blockedDates.includes(date.format('YYYY-MM-DD'));
        }
    });

    $('#dateRangePicker').on('apply.daterangepicker', function (ev, picker) {
        var startDate = picker.startDate.format('YYYY-MM-DD');
        var endDate = picker.endDate.format('YYYY-MM-DD');
        $("#formStart").val(startDate);
        $("#formEnd").val(endDate);
        $("#submitButton").removeAttr('hidden');
        $("#BillingAddress").removeAttr('hidden');
        $("#BillingAddressLabel").removeAttr('hidden');
        $("#dateRangePicker").remove();
    });
});
